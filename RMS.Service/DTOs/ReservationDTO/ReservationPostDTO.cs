using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs.ReservationDTO
{
    public class ReservationPostDTO
    {
        public int TableId { get; set; }
        public DateTime Time { get; set; }
        public string ClientName { get; set; }
    }
    public class ReservationPostDTOValidator : AbstractValidator<ReservationPostDTO>
    {
        public ReservationPostDTOValidator()
        {
            RuleFor(x => x.TableId).NotNull().NotEmpty();
            RuleFor(x => x.ClientName).NotNull().NotEmpty();
            RuleFor(x => x.Time).NotNull().NotEmpty();

        }
    }
}
