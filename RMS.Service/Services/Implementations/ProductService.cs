using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.ProductDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(ProductPostDTO productDTO)
        {
            if (await _unitOfWork.ProductRepository.IsExistAsync(x => x.Name == productDTO.Name))
                throw new AlreadyExistException($"{productDTO.Name} is already exist.Please change name");
            Product product = _mapper.Map<Product>(productDTO);
            await _unitOfWork.ProductRepository.InsertAsync(product);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
            Product product = await _unitOfWork.ProductRepository.GetAsync(x => x.Id == id);
            if (product == null)
                throw new NotFoundException("Product doesn't exist id");
            product.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, ProductPostDTO productDTO)
        {
            Product product = await _unitOfWork.ProductRepository.GetAsync(x => x.Id == id);
            if (product == null)
                throw new NotFoundException("Product doesn't exist id");
            _mapper.Map<ProductPostDTO,Product>(productDTO,product);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ProductGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<Product> product = await _unitOfWork.ProductRepository.GetAllAsync(x => x.IsDeleted == false);
            List<TEntity> productGetAllDTO = new List<TEntity>();
            foreach (var item in product)
            {
                productGetAllDTO.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.ProductRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            ProductGetAllDTO<TEntity> productGetAll = new ProductGetAllDTO<TEntity>
            {
                Products = productGetAllDTO,
                Count = count
            };
            return productGetAll;
        }

        public async Task<PagenatedListDTO<ProductGetDTO>> GetAllFilteredAsync(int page, int pageSize, string search = "")
        {
            List<Product> products = await _unitOfWork.ProductRepository.GetAllPagenatedAsync(x=>x.IsDeleted==false,page,pageSize);
            List<ProductGetDTO> productListDTO = new List<ProductGetDTO>();
            foreach (var item in products)
            {
                productListDTO.Add(_mapper.Map<ProductGetDTO>(item));
            }
            int count = await _unitOfWork.ProductRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            PagenatedListDTO<ProductGetDTO> pagenatedList = new PagenatedListDTO<ProductGetDTO>(productListDTO,page,count,pageSize);
            return pagenatedList;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Product product = await _unitOfWork.ProductRepository.GetAsync(x => x.Id == id);
            if (product==null) throw new NotFoundException("Product doesn't exist id");
            TEntity entity = _mapper.Map<TEntity>(product);
            return entity;
        }

        public async Task<TEntity> GetByNameAsync<TEntity>(string name)
        {
            Product product = await _unitOfWork.ProductRepository.GetAsync(x => x.Name == name);
            if (product == null) throw new NotFoundException("Product doesn't exist name");
            TEntity entity = _mapper.Map<TEntity>(product);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.ProductRepository.IsExistAsync(x=>x.Id==id);
        }
    }
}
