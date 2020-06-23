using System.Collections.Generic;

namespace LangLearn.ViewModels {
    /// <summary>
    /// View model for a Vocab Question 
    /// </summary>
    public class VocabQuestion {
        public string Question { get; set; }
        public string Answer { get; set; }
        public List<string> Options { get; set; }
    }
}