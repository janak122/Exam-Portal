using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPortal.Models
{
    [Table("MCQQuestions")]
    public class MCQQuestion : Question
    {
        public MCQQuestion()
        {
            MCQOptions = new List<MCQOption>();
            MCQPaper = new MCQPaper();
            TrueAnswer = new MCQOption();
        }

        #region My Paper
        [Required]
        public int MCQPaperId { get; set; }
        public MCQPaper MCQPaper { get; set; }
        #endregion


        #region True Answer
        public int? MCQOptionId { get; set; }
        [ForeignKey(nameof(MCQOptionId))]
        public MCQOption TrueAnswer { get; set; }
        #endregion


        public List<MCQOption> MCQOptions { get; set; }

    }

}
