using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core
{
    public interface IUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; }
        public IDepoRepository DepoRepository { get; }
        public IFoodOrderRepository FoodOrderRepository { get; }
        public IFoodProductRepository FoodProductRepository { get; }
        public IFoodRepository FoodRepository { get; }
        public IHallRepository HallRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IOrderTypeRepository OrderTypeRepository { get; }
        public IPaymentRepository PaymentRepository { get; }
        public IPaymentTypeRepository PaymentTypeRepository { get; }
        public IProductDepoRepository ProductDepoRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IProductTypeRepository ProductTypeRepository { get; }
        public IPurchaseRepository PurchaseRepository { get; }
        public IReceiptRepository ReceiptRepository { get; }
        public IReservationRepository ReservationRepository { get; }
        public IStaffRepository StaffRepository { get; }
        public IStaffTypeRepository StaffTypeRepository { get; }
        public ITableRepository TableRepository { get; }
        public ITableStatusRepository TableStatusRepository { get; }

        Task CommitAsync();
    }
}
