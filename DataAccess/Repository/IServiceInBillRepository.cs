﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IServiceInBillRepository
    {
        Task<List<ServiceInBill>> GetServiceInBills();

        Task<ServiceInBill> GetServiceInBillById(int ServiceInCinemaId, int BillId);

        Task DeleteServiceInBill(int ServiceInCinemaId, int BillId);

        Task UpdateServiceInBill(ServiceInBill m);
        Task AddServiceInBill(ServiceInBill m);
        Task<List<ServiceInBill>> SearchByCinemaId(int ServiceId, int page, int pageSize);
    }
}
