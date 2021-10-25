using System;
using Grpc.Core;
using Grpc.Net.Client;
using MerchandiseService.Grpc;

using var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new MerchandiseServiceGrpc.MerchandiseServiceGrpcClient(channel);

try
{
    var merchPackResponse = await client.GetMerchPackAsync(new GetMerchPackRequest
    {
        Id = 1
    });
    Console.WriteLine(merchPackResponse.MerchPack.ItemId);
    Console.WriteLine(merchPackResponse.MerchPack.ItemName);
}
catch (RpcException e)
{
    Console.WriteLine(e);
}