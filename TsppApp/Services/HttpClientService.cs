using Newtonsoft.Json;
using System.Net.Http.Json;
using TsppAPI.Models;
using TsppApp.Models;
using TsppApp.Models.Filters;
using TsppApp.Services.Abstract;

namespace TsppApp.Services
{
    internal class HttpClientService : IHttpClientService
    {
        static readonly HttpClient client = new()
        {
            BaseAddress = new Uri("https://localhost:7153/api/")
        };

        public async Task<TModel> PostAsync<TModel, TDto>(TDto dto)
            where TModel : class, IEntity
            where TDto : class, IDto<TModel>
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(typeof(TModel).Name, dto);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TModel>(responseBody);
        }
        public async Task<ICollection<TModel>> GetAsync<TModel>()
            where TModel : class, IEntity
        {
            HttpResponseMessage response = await client.GetAsync(typeof(TModel).Name);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ICollection<TModel>>(responseBody);
        }
        public async Task<TModel> PutAsync<TModel, TDto>(TDto dto)
            where TModel : class, IEntity
            where TDto : class, IDto<TModel>
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(typeof(TModel).Name, dto);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TModel>(responseBody);
        }
        public async Task<bool> DeleteAsync<TModel>(int id)
            where TModel : class, IEntity
        {
            HttpResponseMessage response = await client.DeleteAsync(typeof(TModel).Name + $"/{id}");
            response.EnsureSuccessStatusCode();
            return true;
        }
        public async Task<TModel> GetByIdAsync<TModel>(int id)
            where TModel : class, IEntity
        {
            HttpResponseMessage response = await client.GetAsync(typeof(TModel).Name + $"/{id}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TModel>(responseBody);
        }
        public async Task<bool> AuthorizeUser(AuthorizationDto authorizationDto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("Authorization", authorizationDto);
            return response.IsSuccessStatusCode;
        }

        public async Task<ICollection<TModel>> GetFilteredAsync<TModel, TFilter>(TFilter filter)
            where TModel : class, IEntity
            where TFilter : class, IFilter<TModel>
        {
            HttpResponseMessage response = await client.PostAsJsonAsync($"{typeof(TModel).Name}\\Filter", filter);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ICollection<TModel>>(responseBody);
        }
        public async Task<int> GetAmountAsync<TModel>()
            where TModel : class, IEntity
        {
            HttpResponseMessage response = await client.GetAsync($"{typeof(TModel).Name}\\Amount");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<int>(responseBody);
        }

        public async Task<double> GetMatrixDetermenantAsync<TModel>(MatrixDto matrixDto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync($"{typeof(TModel).Name}\\Matrix", matrixDto.Matrix);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<double>(responseBody);
        }
    }
}
