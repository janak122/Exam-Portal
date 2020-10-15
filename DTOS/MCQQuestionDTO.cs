using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.DTOS
{
    public class MCQQuestionDTO : QuestionDTO
    {
        public List<string> Opetions { get; set; }
        public int TrueAnswer { get; set; }
    }
}
