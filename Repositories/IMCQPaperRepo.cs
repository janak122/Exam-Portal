using ExamPortal.Models;
using ExamPortal.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Repositories
{
    public interface IMCQPaperRepo
    {
        public MCQPaper GetByPaperCode(string paperCode);
        public IEnumerable<MCQPaper> GetByTeacherEmail(string email);
        public MCQPaper Create(MCQPaper paper);
    }

    public class MCQPaperRepoImpl : IMCQPaperRepo
    {
        public MCQPaperRepoImpl(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        private AppDbContext AppDbContext { get; }

        public MCQPaper Create(MCQPaper paper)
        {
            AppDbContext.Add(paper);
            AppDbContext.SaveChanges();
            return paper;
        }

        public MCQPaper GetByPaperCode(string paperCode)
        {
            return AppDbContext.MCQPapers.Where(paper => paper.PaperCode.Equals(paperCode)).FirstOrDefault();
        }

        public IEnumerable<MCQPaper> GetByTeacherEmail(string email)
        {
            return AppDbContext.MCQPapers.Where(paper => paper.TeacherEmailId.Equals(email));
        }
    }

}
