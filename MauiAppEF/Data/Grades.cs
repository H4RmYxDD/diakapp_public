using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MauiAppEF.Data {
    [PrimaryKey(nameof(StudentId), nameof(SubjectId))]
    public class Grades
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        [Range(1, 5, ErrorMessage = "the value must be between 1 and 5.")]
        public int Grade { get; set; }
    }
}