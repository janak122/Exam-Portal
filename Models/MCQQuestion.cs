using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Models
{
    public class MCQQuestion : Question
    {
        public int MCQPaperId { get; set; }
        public MCQPaper MCQPaper { get; set; }

        public int MCQOptionId { get; set; }
        [ForeignKey("MCQOptionId")]
        public MCQOption TrueAnswer { get; set; }

        public ICollection<MCQOption> MCQOptions { get; set; }
    }
    public class MCQOption
    {
        public int Id { get; set; }
        public string OptionText { get; set; }
    }
}
