using AutoMapper;
using RMS.Core;
using RMS.Core.Entities;
using RMS.Service.DTOs;
using RMS.Service.DTOs.ReservationDTO;
using RMS.Service.Exceptions;
using RMS.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Services.Implementations
{
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReservationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<double> CreateAsync(ReservationPostDTO reservationDTO)
        {
            if (await _unitOfWork.ReservationRepository.HasReservedAsync(reservationDTO.TableId,reservationDTO.Time))
                throw new AlreadyExistException($"Reservation is already exist. Please change time!");
            reservationDTO.Time.AddHours(4);
            Reservation reservation = _mapper.Map<Reservation>(reservationDTO);
            await _unitOfWork.ReservationRepository.InsertAsync(reservation);
            DateTime currentTime = DateTime.UtcNow.AddHours(4);
            var span = (reservation.Time - currentTime);
            double total = (double)span.TotalMilliseconds;
            await _unitOfWork.CommitAsync();
            return total-3600000;
        }

        public async Task Delete(int id)
        {
            Reservation reservation = await _unitOfWork.ReservationRepository.GetAsync(x => x.Id == id);
            if (reservation == null)
            {
                throw new NotFoundException("Reservation doesn't exist in this Id");
            }
            reservation.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }

        public async Task EditAsync(int id, ReservationPostDTO reservationDTO)
        {
            Reservation reservation = await _unitOfWork.ReservationRepository.GetAsync(x => x.Id == id);
            if (reservation == null)
            {
                throw new Exception("Reservation doesn't exist in this Id");
            }
            if (await _unitOfWork.ReservationRepository.HasReservedAsync(reservationDTO.TableId, reservationDTO.Time))
            {
                throw new Exception("Reservation is Already Exist with this Name");
            }
            _mapper.Map<ReservationPostDTO, Reservation>(reservationDTO, reservation);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ReservationGetAllDTO<TEntity>> GetAllAsync<TEntity>()
        {
            List<Reservation> reservations = await _unitOfWork.ReservationRepository.GetAllAsync(x => x.IsDeleted == false);
            List<TEntity> reservationGetAllDTO = new List<TEntity>();
            foreach (var item in reservations)
            {
                reservationGetAllDTO.Add(_mapper.Map<TEntity>(item));
            }
            int count = await _unitOfWork.ReservationRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            ReservationGetAllDTO<TEntity> reservationGetAll = new ReservationGetAllDTO<TEntity>
            {
                Reservations = reservationGetAllDTO,
                Count = count
            };
            return reservationGetAll;
        }

        public async Task<PagenatedListDTO<ReservationGetDTO>> GetAllFilteredAsync(int page, int pageSize)
        {
            List<Reservation> reservations = await _unitOfWork.ReservationRepository.GetAllPagenatedAsync(x => x.IsDeleted == false, page, pageSize);
            List<ReservationGetDTO> reservationListDTO = new List<ReservationGetDTO>();
            foreach (var item in reservations)
            {
                reservationListDTO.Add(_mapper.Map<ReservationGetDTO>(item));
            }
            int count = await _unitOfWork.ReservationRepository.GetTotalCountAsync(x => x.IsDeleted == false);
            PagenatedListDTO<ReservationGetDTO> pagenatedList = new PagenatedListDTO<ReservationGetDTO>(reservationListDTO, page, count, pageSize);
            return pagenatedList;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int id)
        {
            Reservation reservation= await _unitOfWork.ReservationRepository.GetAsync(x => x.Id == id && x.IsDeleted == false);
            if (reservation == null) throw new Exception("Reservation doesn't exist in this Id");

            TEntity entity = _mapper.Map<TEntity>(reservation);
            return entity;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await _unitOfWork.ReservationRepository.IsExistAsync(x => x.Id == id && x.IsDeleted == false);
        }
    }
}
