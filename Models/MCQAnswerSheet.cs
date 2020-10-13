using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public class MCQAnswerSheet : AnswerSheet
    {
        public int MarksObtained { get; set; }
    }

    public interface IMCQAnswerSheetRepo
    {
        public MCQAnswerSheet GetMCQAnswerSheet(string PaperCode, string StudentEmailId);
        public IEnumerable<MCQAnswerSheet> GetMCQAnswerSheets(string StudentEmailId);
    }
}
