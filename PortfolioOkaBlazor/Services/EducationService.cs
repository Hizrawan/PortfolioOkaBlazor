using PortfolioOkaBlazor.Components.Pages;
using PortfolioOkaBlazor.Domain;

namespace PortfolioOkaBlazor.Services
{

    public class EducationService
    {
        private readonly HttpClient _httpClient;

        public EducationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EducationData>> GetEducationsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<EducationData>>("/Educations");
        }
    }


}