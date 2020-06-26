using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using LangLearn.ViewModels;

namespace LangLearn.Services {
    public class VocabService : IVocabService {
        
        private readonly HttpClient _http;
        private VocabQuestion[] _vocabQuestions;
        private int _currentIndex;
        private readonly Random _rand;
        private const string QuestionsPath = "sample-data/vocab_questions.json";
        
        public VocabService(HttpClient http) {
            _rand = new Random();
            _http = http;
        }

        public async Task<VocabQuestion[]> GetAllVocab() {
            return _vocabQuestions ??= await _http.GetFromJsonAsync<VocabQuestion[]>(QuestionsPath);
        }

        public async Task<VocabQuestion> GetNextQuestion() {
            var vocab = await GetAllVocab();
            GetRandomIndex();
            return vocab[_currentIndex];
        }

        private void GetRandomIndex() {
            var newIndex = _rand.Next(_vocabQuestions.Length);
            
            if (newIndex == _currentIndex) {
                GetRandomIndex();
            }
            _currentIndex = newIndex;
        }
    }
}