using Discount.Grpc.Protos;
using System;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtosService.DiscountProtosServiceClient _discountProtosServiceClient;

        public DiscountGrpcService(DiscountProtosService.DiscountProtosServiceClient discountProtosServiceClient)
        {
            _discountProtosServiceClient = discountProtosServiceClient ?? throw new ArgumentNullException(nameof(discountProtosServiceClient));
        }
        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName };
            return await _discountProtosServiceClient.GetDiscountAsync(discountRequest);
        }
    }
}
