namespace BSIT_32E1_Elective_2_Assignment_1.Models
{
    public class QuizQuestion
    {
        public int Number { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public Dictionary<string, string> Options { get; set; } = new();
        public string CorrectOptionKey { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }
}