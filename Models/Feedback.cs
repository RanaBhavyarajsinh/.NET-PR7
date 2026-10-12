using System.ComponentModel.DataAnnotations;

namespace pr7.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the subject.")]
        [StringLength(100, ErrorMessage = "Subject cannot exceed 100 characters.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter your enrollment number.")]
        [StringLength(20, ErrorMessage = "Enrollment number cannot exceed 20 characters.")]
        public string EnrollmentNo { get; set; }

        [Range(1, 5, ErrorMessage = "Please select a rating between 1 and 5.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter your comment.")]
        [StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")]
        public string Comment { get; set; }
    }
}