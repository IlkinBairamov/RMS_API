using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.FoodDTO;
using RMS.Service.Exceptions;
using RMS.Service.HelperServices.Interfaces;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class FoodService : IFoodService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;

        public FoodService(IUnitOfWork unitOfWork, IMapper mapper, IFileManager fileManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileManager = fileManager;
        }
        public async Task<FoodCreateReturnDTO> CreateAsync(FoodPostDTO foodDTO)
        {
            if (await _unitOfWork.FoodRepository.IsExistAsync(x => x.Name == foodDTO.Name))
                throw new AlreadyExistException($"{foodDTO.Name} is already exist.Please change name");
            SavedFileDTO savedFileDTO = null;
            Food food = _mapper.Map<Food>(foodDTO);
            if (foodDTO.File!=null)
            {
                if (!foodDTO.File.ContentType.Contains("image"))
                    throw new FileFormatException("Upload Type must be image(png,jpg,jpeg)");
                savedFileDTO = await _fileManager.Save(foodDTO.File,"foods");
                food.Image = savedFileDTO.Path;
            }
            await _unitOfWork.FoodRepository.InsertAsync(food);
            await _unitOfWork.CommitAsync();
            FoodCreateReturnDTO returnDTO = new FoodCreateReturnDTO
            {
                Id = food.Id,
                Path = savedFileDTO.Path
            };
            return returnDTO;
        }

        public async Task Delete(int id)
        {
            Food food = await _unitOfWork.FoodRepository.GetAsync(x => x.Id == id && x.IsDeleted==false);
            if (food == null)
                throw new NotFoundException("Food doesn't exist in this id");
            food.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, FoodEditDTO foodDTO)
        {
            SavedFileDTO savedFileDTO = null;
            Food food = await _unitOfWork.FoodRepository.GetAsync(x => x.Id == id);
            if (food == null)
                throw new NotFoundException("Food doesn't exist in this id");
            _mapper.Map<FoodEditDTO, Food>(foodDTO, food);
            if (foodDTO.File != null)
            {
                if (foodDTO.File.ContentType != "image/jpeg" && foodDTO.File.ContentType != "image/png" && foodDTO.File.ContentType != "image/jpg")
                    throw new FileFormatException("Upload Type must be image(png,jpg,jpeg)");
                savedFileDTO = await _fileManager.Save(foodDTO.File, "foods");
                food.Image = savedFileDTO.ChangedFileName;
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<FoodGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<Food> food = await _unitOfWork.FoodRepository.GetAllAsync(x => x.IsDeleted == false);
            List<TEntity> foodGetAllDTO = new List<TEntity>();
            foreach (var item in food)
            {
                foodGetAllDTO.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.ProductRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            FoodGetAllDTO<TEntity> foodGetAll = new FoodGetAllDTO<TEntity>
            {
                Foods = foodGetAllDTO,
                Count = count
            };
            return foodGetAll;
        }

        public async Task<PagenatedListDTO<FoodGetDTO>> GetAllFilteredAsync(int page, int pageSize)
        {
            List<Food> foods = await _unitOfWork.FoodRepository.GetAllPagenatedAsync(x => x.IsDeleted == false, page, pageSize,"Category");
            List<FoodGetDTO> foodListDTO = new List<FoodGetDTO>();
            foreach (var item in foods)
            {
                foodListDTO.Add(_mapper.Map<FoodGetDTO>(item));
            }
            int count = await _unitOfWork.FoodRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            PagenatedListDTO<FoodGetDTO> pagenatedList = new PagenatedListDTO<FoodGetDTO>(foodListDTO, page, count, pageSize);
            return pagenatedList;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Food food = await _unitOfWork.FoodRepository.GetAsync(x => x.Id == id, "FoodProducts.Product", "Category");
            if (food == null) throw new NotFoundException("Food doesn't exist in this id");
            TEntity entity = _mapper.Map<TEntity>(food);
            //FoodGetDTO foodDto = _mapper.Map<FoodGetDTO>(food);
            //foodDto.Products = await _unitOfWork.ProductRepository.GetAllAsync(x=>x.FoodProducts.);
            return entity;
        }

        public async Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            Food food = await _unitOfWork.FoodRepository.GetAsync(x => x.Name == name, "FoodProducts.Products");
            if (food == null) throw new NotFoundException("Food doesn't exist in this name");
            TEntity entity = _mapper.Map<TEntity>(food);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.FoodRepository.IsExistAsync(x => x.Id == id && x.IsDeleted == false);
        }
    }
}
