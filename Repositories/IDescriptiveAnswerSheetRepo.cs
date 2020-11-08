using ExamPortal.Models;
using ExamPortal.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace ExamPortal.Repositories
{
    public interface IDescriptiveAnswerSheetRepo
    {
        public DescriptiveAnswerSheet GetByPaperCodeAndStudentEmail(string PaperCode, string StudentEmailId);
        public IEnumerable<DescriptiveAnswerSheet> GetByStudentEmail(string StudentEmailId);

    }
    public class DescriptiveAnswerSheetRepoImpl : IDescriptiveAnswerSheetRepo
    {
        #region Constructor and Properties
        public DescriptiveAnswerSheetRepoImpl(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public AppDbContext DbContext { get; }
        #endregion
        public DescriptiveAnswerSheet GetByPaperCodeAndStudentEmail(string PaperCode, string StudentEmailId)
        {
            return DbContext.DescriptiveAnswerSheets
                .FirstOrDefault(ele => ele.DescriptivePaper.PaperCode == PaperCode && ele.StudentEmailId == StudentEmailId);
        }

        public IEnumerable<DescriptiveAnswerSheet> GetByStudentEmail(string StudentEmailId)
        {
            return DbContext.DescriptiveAnswerSheets.Where(ele => ele.StudentEmailId == StudentEmailId);
        }
    }
}
