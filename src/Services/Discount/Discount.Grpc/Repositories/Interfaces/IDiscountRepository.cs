﻿using Discount.Grpc.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discount.Grpc.Repositories.Interfaces
{
    public interface IDiscountRepository
    {
        Task<List<Coupon>> GetDiscounts();
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productName);
    }
}
