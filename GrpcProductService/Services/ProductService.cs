using Grpc.Core;
using grpcProductServer;

namespace GrpcProductService.Services
{
    public class ProductService : Product.ProductBase
    {
        public async override Task<GetProductByIdReply> GetProductById(GetProductByIdRequest request, ServerCallContext context)
        {
            List<ProductModel> products = new() { new ProductModel { Id=1, Name="p1"}, new ProductModel { Id=2,Name="p2"}, new ProductModel { Id = 3, Name = "p3" } };
            var prd = new GetProductByIdReply();
            prd.ProductList.AddRange(products.Where(x=>x.Id== request.Id));
            return await Task.FromResult(prd);
        }
    }
}
