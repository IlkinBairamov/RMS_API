using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs.ProductTypeDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ProductTypeService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(ProductTypePostDTO ProductTypeDTO)
        {
            if (await _unitOfWork.ProductTypeRepository.IsExistAsync(x => x.Name == ProductTypeDTO.Name))
                throw new AlreadyExistException($"{ProductTypeDTO.Name} is already exist. Please change name!");
            ProductType productType  = _mapper.Map<ProductType>(ProductTypeDTO);
            await _unitOfWork.ProductTypeRepository.InsertAsync(productType);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            ProductType type = await _unitOfWork.ProductTypeRepository.GetAsync(x => x.Id == id);
            if (type == null)
            {
                throw new NotFoundException("table doesn't exist in this Id");
            }
            type.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, ProductTypePostDTO ProductTypeDTO)
        {
            ProductType table = await _unitOfWork.ProductTypeRepository.GetAsync(x => x.Id == id);
            if (table == null)
            {
                throw new Exception("Table doesn't exist in this Id");
            }
            _mapper.Map<ProductTypePostDTO, ProductType>(ProductTypeDTO, table);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ProductTypeGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<ProductType> entities = await _unitOfWork.ProductTypeRepository.GetAllAsync(x => x.IsDeleted == false);
            List<TEntity> productTypes = new List<TEntity>();
            foreach (var item in entities)
            {
                productTypes.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.ProductTypeRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            ProductTypeGetAllDTO<TEntity> productTypeGetAll = new ProductTypeGetAllDTO<TEntity>
            {
                ProductTypes = productTypes,
                Count = count
            };
            return productTypeGetAll;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            ProductType Name = await _unitOfWork.ProductTypeRepository.GetAsync(x => x.Id == id);
            if (Name == null) throw new NotFoundException("Hall doesn't exist in this Id");
            TEntity entity = _mapper.Map<TEntity>(Name);
            return entity;
        }

        public async Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            ProductType productType = await _unitOfWork.ProductTypeRepository.GetAsync(x => x.Name == name);
            if (productType == null) throw new NotFoundException("Hall doesn't exist in this Name");

            TEntity entity = _mapper.Map<TEntity>(productType);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.ProductTypeRepository.IsExistAsync(x => x.Id == id);
        }
    }
}
