using System.Threading.Tasks;
using LangLearn.ViewModels;

namespace LangLearn.Services {
    public interface IVocabService {
        public Task<VocabQuestion> GetNextQuestion();
        public Task<VocabQuestion[]> GetAllVocab();
    }
}