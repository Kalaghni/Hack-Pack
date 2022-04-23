
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JoshesHackPack.Models
{
    public class Task
    {
        public int ID { get; set; }

        [Display(Name = "Task")]
        public string Name { get; set; }

        [Display(Name = "Member Tasks")]
        public ICollection<MemberTask>? MemberTasks { get; set; }

        [Display(Name = "Sub Tasks")]
        public ICollection<SubTask>? SubTasks { get; set; }
    }
}

