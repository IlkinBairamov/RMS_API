using RMS.Core;
using RMS.Core.Repositories;
using RMS.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ICategoryRepository _categoryRepository;
        private IDepoRepository _depoRepository;
        private IFoodOrderRepository _foodOrderRepository;
        private IFoodProductRepository _foodProductRepository;
        private IFoodRepository _foodRepository;
        private IHallRepository _hallRepository;
        private IOrderRepository _orderRepository;
        private IPaymentRepository _paymentRepository;
        private IPaymentTypeRepository _paymentTypeRepository;
        private IProductDepoRepository _productDepoRepository;
        private IProductRepository _productRepository;
        private IProductTypeRepository _productTypeRepository;
        private IPurchaseRepository _purchaseRepository;
        private IReceiptRepository _receiptRepository;
        private IReservationRepository _reservationRepository;
        private IStaffRepository _staffRepository;
        private IStaffTypeRepository _staffTypeRepository;
        private ITableRepository _tableRepository;
        private ITableStatusRepository _tablestatusRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public ICategoryRepository CategoryRepository => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        public IDepoRepository DepoRepository => _depoRepository = _depoRepository ?? new DepoRepository(_context);
        public IFoodOrderRepository FoodOrderRepository => _foodOrderRepository = _foodOrderRepository ?? new FoodOrderRepository(_context);
        public IFoodProductRepository FoodProductRepository => _foodProductRepository = _foodProductRepository ?? new FoodProductRepository(_context);
        public IFoodRepository FoodRepository => _foodRepository = _foodRepository ?? new FoodRepository(_context);
        public IHallRepository HallRepository => _hallRepository = _hallRepository ?? new HallRepository(_context);
        public IOrderRepository OrderRepository => _orderRepository = _orderRepository ?? new OrderRepository(_context);
        public IPaymentRepository PaymentRepository => _paymentRepository = _paymentRepository ?? new PaymentRepository(_context);
        public IPaymentTypeRepository PaymentTypeRepository => _paymentTypeRepository = _paymentTypeRepository ?? new PaymentTypeRepository(_context);
        public IProductDepoRepository ProductDepoRepository => _productDepoRepository = _productDepoRepository ?? new ProductDepoRepository(_context);
        public IProductRepository ProductRepository => _productRepository = _productRepository ?? new ProductRepository(_context);
        public IProductTypeRepository ProductTypeRepository => _productTypeRepository = _productTypeRepository ?? new ProductTypeRepository(_context);
        public IPurchaseRepository PurchaseRepository => _purchaseRepository = _purchaseRepository ?? new PurchaseRepository(_context);
        public IReceiptRepository ReceiptRepository => _receiptRepository = _receiptRepository ?? new ReceiptRepository(_context);
        public IReservationRepository ReservationRepository => _reservationRepository = _reservationRepository ?? new ReservationRepository(_context);
        public IStaffRepository StaffRepository => _staffRepository = _staffRepository ?? new StaffRepository(_context);
        public IStaffTypeRepository StaffTypeRepository => _staffTypeRepository = _staffTypeRepository ?? new StaffTypeRepository(_context);
        public ITableRepository TableRepository => _tableRepository = _tableRepository ?? new TableRepository(_context);
        public ITableStatusRepository TableStatusRepository => _tablestatusRepository = _tablestatusRepository ?? new TableStatusRepository(_context);

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
