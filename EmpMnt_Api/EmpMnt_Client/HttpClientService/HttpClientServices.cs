
namespace EmpMnt_Client.HttpClientService
{
    public class HttpClientServices : IHttpClientServices
    {
        public Task<T> DeleteAsync<T>(string requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteWithBodyAsync<T>(string requestUri, object content)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync<T>(string requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostAsync<T>(string requestUri, object content)
        {
            throw new NotImplementedException();
        }

        public Task<T> PutAsync<T>(string requestUri, object content)
        {
            throw new NotImplementedException();
        }
    }
}
