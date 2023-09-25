namespace FunctionalTests.Extensions;

static class HttpClientExtensions
{
    public static HttpClient CreateIdempotentClient(this TestServer server)
    {
        //demo comentario
        var client = server.CreateClient();
        client.DefaultRequestHeaders.Add("x-requestid", Guid.NewGuid().ToString());
        return client;
    }
}
