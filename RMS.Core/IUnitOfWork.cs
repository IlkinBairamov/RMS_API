using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core
{
    internal interface IUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; set; }
        public IDepoRepository DepoRepository { get; set; }
        public IFoodOrderRepository FoodOrderRepository { get; set; }
        public IFoodProductRepository FoodProductRepository { get; set; }
        public IFoodRepository FoodRepository { get; set; }
        public IHallRepository HallRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IOrderTypeRepository OrderTypeRepository { get; set; }
        public IPaymentRepository PaymentRepository { get; set; }
        public IPaymentTypeRepository PaymentTypeRepository { get; set; }
        public IProductDepoRepository ProductDepoRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public IProductTypeRepository ProductTypeRepository { get; set; }
        public IPurchaseRepository PurchaseRepository { get; set; }
        public IReceiptRepository ReceiptRepository { get; set; }
        public IReservationRepository ReservationRepository { get; set; }
        public IStaffRepository StaffRepository { get; set; }
        public IStaffTypeRepository StaffTypeRepository { get; set; }
        public ITableRepository TableRepository { get; set; }
        public ITableStatusRepository TableStatusRepository { get; set; }

        Task CommitAsync();
    }
}
