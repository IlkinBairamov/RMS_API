using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.ReceiptDTO;
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
    public class ReceiptService : IReceiptService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRandomGenerator _randomGenerator;

        public ReceiptService(IUnitOfWork unitOfWork, IMapper mapper, IRandomGenerator randomGenerator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _randomGenerator = randomGenerator;
        }

        public async Task<ReceiptGetDTO> CreateAsync(ReceiptPostDTO receiptDTO)
        {
            if (await _unitOfWork.ReceiptRepository.IsExistAsync(x=>x.OrderId==receiptDTO.OrderId && x.IsDeleted == false))
            {
                throw new AlreadyExistException("Receipt is Already Exist in this id!!!");
            }
            Receipt receipt = new Receipt { OrderId = receiptDTO.OrderId };
            Order order = await _unitOfWork.OrderRepository.GetAsync(x=>x.Id==receiptDTO.OrderId && x.IsDeleted==false, "FoodOrders.Food");
            receipt.Barcode = _randomGenerator.Generate(8);
            receipt.TotalPrice = (decimal)receiptDTO.TotalPrice;
            receipt.Order = order;
            await _unitOfWork.ReceiptRepository.InsertAsync(receipt);
            await _unitOfWork.CommitAsync();
            ReceiptGetDTO receiptGetDTO = _mapper.Map<ReceiptGetDTO>(receipt);
            return receiptGetDTO;
        }

        public async Task Delete(int id)
        {
            Receipt receipt = await _unitOfWork.ReceiptRepository.GetAsync(x => x.Id == id);
            if (receipt == null)
            {
                throw new Exception("Receipt doesn't exist in this Id");
            }
            receipt.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task<ReceiptGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<Receipt> receipts = await _unitOfWork.ReceiptRepository.GetAllAsync(x => x.IsDeleted == false);
            List<TEntity> receiptGetAllDTO = new List<TEntity>();
            foreach (var item in receipts)
            {
                receiptGetAllDTO.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.ReceiptRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            ReceiptGetAllDTO<TEntity> receiptGetAll = new ReceiptGetAllDTO<TEntity>
            {
                Receipts = receiptGetAllDTO,
                Count = count
            };
            return receiptGetAll;
        }

        public async Task<PagenatedListDTO<ReceiptGetDTO>> GetAllFilteredAsync(int page, int pageSize)
        {
            List<Receipt> receipts = await _unitOfWork.ReceiptRepository.GetAllPagenatedAsync(x => x.IsDeleted == false, page, pageSize);
            List<ReceiptGetDTO> receiptListDTO = new List<ReceiptGetDTO>();
            foreach (var item in receipts)
            {
                receiptListDTO.Add(_mapper.Map<ReceiptGetDTO>(item));
            }
            int count = await _unitOfWork.ReceiptRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            PagenatedListDTO<ReceiptGetDTO> pagenatedList = new PagenatedListDTO<ReceiptGetDTO>(receiptListDTO, page, count, pageSize);
            return pagenatedList;
        }
        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Receipt receipt = await _unitOfWork.ReceiptRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if (receipt == null) throw new NotFoundException("Receipt doesn't exist in this Id");

            TEntity entity = _mapper.Map<TEntity>(receipt);
            return entity;
        }
        public async Task<TEntity> GetByOrderAsync<TEntity>(int orderId)
        {
            Receipt receipt = await _unitOfWork.ReceiptRepository.GetAsync(x => x.OrderId == orderId, "Order.FoodOrders.Food", "Order.Staff");
            if (receipt == null) throw new NotFoundException("Receipt doesn't exist in this order");

            TEntity entity = _mapper.Map<TEntity>(receipt);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.ReceiptRepository.IsExistAsync(x => x.Id == id && x.IsDeleted == false);

        }
    }
}
