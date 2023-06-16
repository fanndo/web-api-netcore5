using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebAp.Restful.Contracts;
using WebAp.Restful.Dto;

namespace WebAp.Restful.Services
{
    public class PostService : IPostService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;
        public PostService(IHttpClientFactory httpClientFactory, JsonSerializerOptions options)
        {
            _httpClientFactory = httpClientFactory;
            _options = options;
        }

        public async Task<IList<Post>> GetAll()
        {

            try
            {
                using (var client = _httpClientFactory.CreateClient("api"))
                {
                    var httpResponse = await client.GetAsync("/posts");

                    if (httpResponse.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        throw new System.Exception($"StatusCode: { httpResponse.StatusCode }");
                    }

                    var responseData = await httpResponse.Content.ReadAsStringAsync();

                    var result = JsonSerializer.Deserialize<List<Post>>(responseData, _options);

                    return result;
                }
            }
            catch (System.Exception)
            {

                throw;
            }





        }
    }
}
