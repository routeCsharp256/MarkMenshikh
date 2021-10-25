using System.Threading.Tasks;
using Grpc.Core;
using MerchandiseService.Grpc;

namespace MerchandiseService.Api.GrpcServices
{
    public class MerchandiseServiceGrpcService : MerchandiseServiceGrpc.MerchandiseServiceGrpcBase 
    {
        public override async Task<GetMerchPackResponse> GetMerchPack(
            GetMerchPackRequest request,
            ServerCallContext context)
        {
            return new GetMerchPackResponse
            {
                MerchPack = new MerchPack
                {
                    ItemId = 1,
                    ItemName = "T-Shirt"
                }
            };
        }

        public override async Task<GetEmployeePacksResponse> GetEmployeePacks(
            GetEmployeePacksRequest request, 
            ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Internal, "not implemented"));
        }
    }
}