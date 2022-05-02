using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.TableDTO
{
    public class TablePostDTO
    {
        public int Number { get; set; }
        public int AmountOfSeat { get; set; }
        public int? Deposite { get; set; }
        public bool HasDeposite { get; set; }
        public int StatusId { get; set; }
        public int HallId { get; set; }
    }
    public class TablePostDTOValidator : AbstractValidator<TablePostDTO>
    {
        public TablePostDTOValidator()
        {
            RuleFor(x => x.Number).GreaterThanOrEqualTo(1).NotNull();
            RuleFor(x => x.AmountOfSeat).GreaterThanOrEqualTo(2).NotNull();
            RuleFor(x => x.Deposite).GreaterThanOrEqualTo(0).NotNull();
            RuleFor(x => x.StatusId).GreaterThanOrEqualTo(1).NotNull();
            RuleFor(x => x.HallId).GreaterThanOrEqualTo(1).NotNull();
        }
    }
}
