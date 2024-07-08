using PortfolioOkaBlazor.Components.Pages;
using PortfolioOkaBlazor.Domain;

namespace PortfolioOkaBlazor.Services
{

    public class SkillsService
    {
        private readonly HttpClient _httpClient;

        public SkillsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SkillData>> GetSkillsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<SkillData>>("/Skills");
        }
    }


}