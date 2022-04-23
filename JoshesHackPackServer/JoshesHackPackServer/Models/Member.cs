using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JoshesHackPack.Models 
{
    public class Member
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "The name cannot be left blank.")]
        [StringLength(50, ErrorMessage = "Name cannot be more than 100 characters long.")]
        public string Name { get; set; }

        public ICollection<MemberTask>? MemberTasks { get; set; }
    }
}
