using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public class MCQPaper : Paper
    {
        public ICollection<MCQQuestion> Questions { get; set; }
    }

    public interface IMCQPaperRepo
    {
        public MCQPaper GetPaper(string paperCode);
        public IEnumerable<MCQPaper> GetPapersByAuthor(string email);

    }
}
