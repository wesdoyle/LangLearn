using System.Collections.Generic;
using System.Threading.Tasks;
using LangLearn.ViewModels;

namespace LangLearn.Services {
    public interface IAlphabetService {
        public Task<List<CyrillicAlphaMapping>> GetAlphabet();
    }
}