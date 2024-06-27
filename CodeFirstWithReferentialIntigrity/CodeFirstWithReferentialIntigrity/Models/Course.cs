using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstWithReferentialIntigrity.Models
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int CrsId { get; set; }
        [StringLength(30)]
        [MinLength(1)]
        public string CrsName { get; set; }
        [Range(1,100)]
        public int Duration { get; set; }

        public ICollection<Topic> Topics { get; set; }
       
    }

    [Table("Topics")]
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        public string TopicName { get; set; }

        public string TeacherName { get; set; }

        [ForeignKey("CrsFK")]
        public Course Course { get; set;}
       
    }
}
