using Grpc.Net.Client;
using grpcProductServer;

var channel = GrpcChannel.ForAddress("https://localhost:7136");
var client = new Product.ProductClient(channel);

var response = await client.GetProductByIdAsync(new GetProductByIdRequest { Id=1});

Console.WriteLine(response);