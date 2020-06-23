using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using LangLearn.ViewModels;

namespace LangLearn.Services {
    /// <summary>
    /// Handles fetching Alphabet data
    /// </summary>
    public class AlphabetService : IAlphabetService {
        private readonly HttpClient _http;
        
        public AlphabetService(HttpClient http) {
            _http = http;
        }
        
        public async Task<List<CyrillicAlphaMapping>> GetAlphabet() {
           return await _http.GetFromJsonAsync<List<CyrillicAlphaMapping>>("sample-data/cyrillic.json");
        }
    }
}