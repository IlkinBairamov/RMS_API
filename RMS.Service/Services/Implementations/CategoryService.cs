using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.CategoryDTO;
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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper, IFileManager fileManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileManager = fileManager;
        }

        public async Task<CategoryCreateReturnDTO> CreateAsync(CategoryPostDTO categoryDTO)
        {
            if (await _unitOfWork.CategoryRepository.IsExistAsync(x => x.Name == categoryDTO.Name))
                throw new AlreadyExistException($"{categoryDTO.Name} is already exist.Please change name");
            SavedFileDTO savedFileDTO = null;
            Category category = _mapper.Map<Category>(categoryDTO);
            if (categoryDTO.File != null)
            {
                if (!categoryDTO.File.ContentType.Contains("image"))
                    throw new FileFormatException("Upload Type must be image(png,jpg,jpeg)");
                savedFileDTO = await _fileManager.Save(categoryDTO.File, "categories");
                category.Image = savedFileDTO.ChangedFileName;
            }
            await _unitOfWork.CategoryRepository.InsertAsync(category);
            await _unitOfWork.CommitAsync();
            CategoryCreateReturnDTO returnDTO = new CategoryCreateReturnDTO
            {
                Id = category.Id,
                Path = savedFileDTO.Path
            };
            return returnDTO;
        }

        public async Task Delete(int id)
        {
            Category category = await _unitOfWork.CategoryRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if (category == null)
                throw new NotFoundException("Category doesn't exist in this id");
            category.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, CategoryEditDTO categoryDTO)
        {
            SavedFileDTO savedFileDTO = null;
            Category category = await _unitOfWork.CategoryRepository.GetAsync(x => x.Id == id);
            if (category == null)
                throw new NotFoundException("Category doesn't exist in this id");
            _mapper.Map<CategoryEditDTO, Category>(categoryDTO, category);
            if (categoryDTO.File != null)
            {
                if (categoryDTO.File.ContentType != "image/jpeg" && categoryDTO.File.ContentType != "image/png" && categoryDTO.File.ContentType != "image/jpg")
                    throw new FileFormatException("Upload Type must be image(png,jpg,jpeg)");
                savedFileDTO = await _fileManager.Save(categoryDTO.File, "categories");
                category.Image = savedFileDTO.ChangedFileName;
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<CategoryGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<Category> category = await _unitOfWork.CategoryRepository.GetAllAsync(x => x.IsDeleted == false,"Foods");
            List<TEntity> categoryGetAllDTO = new List<TEntity>();
            foreach (var item in category)
            {
                categoryGetAllDTO.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.ProductRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            CategoryGetAllDTO<TEntity> categoryGetAll = new CategoryGetAllDTO<TEntity>
            {
                Categories = categoryGetAllDTO,
                Count = count
            };
            return categoryGetAll;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Category category = await _unitOfWork.CategoryRepository.GetAsync(x => x.Id == id, "Foods.FoodProducts.Product");
            if (category == null) throw new NotFoundException("Category doesn't exist in this id");
            TEntity entity = _mapper.Map<TEntity>(category);
            return entity;
        }

        public async Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            Category category = await _unitOfWork.CategoryRepository.GetAsync(x => x.Name == name, "Foods.FoodProducts.Product");
            if (category == null) throw new NotFoundException("Category doesn't exist in this name");
            TEntity entity = _mapper.Map<TEntity>(category);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.CategoryRepository.IsExistAsync(x => x.Id == id && x.IsDeleted==false);
        }

    }
}
