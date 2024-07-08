using PortfolioOkaBlazor.Components.Pages;
using PortfolioOkaBlazor.Domain;

namespace PortfolioOkaBlazor.Services
{

    public class WorkExperienceService
    {
        private readonly HttpClient _httpClient;

        public WorkExperienceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<WorkExperience>> GetWorkExperiencesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<WorkExperience>>("/WorkExperience");
        }
    }


}