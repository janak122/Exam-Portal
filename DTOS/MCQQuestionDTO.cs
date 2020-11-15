using System.Collections.Generic;

namespace ExamPortal.DTOS
{
    public class MCQQuestionDTO : QuestionDTO
    {
        public MCQQuestionDTO()
        {
            Opetions = new List<string>();
        }
        public List<string> Opetions { get; set; }
        public int TrueAnswer { get; set; }
    }
}
