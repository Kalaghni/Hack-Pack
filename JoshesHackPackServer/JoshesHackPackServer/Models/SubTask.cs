using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoshesHackPack.Models
{
    public class SubTask
    {
        public int ID { get; set; }

        [Display(Name = "Sub Task")]
        public string Name { get; set; }


        [Display(Name = "Task")]
        public int TaskID { get; set; }
        public Task Task { get; set; }
    }
}
