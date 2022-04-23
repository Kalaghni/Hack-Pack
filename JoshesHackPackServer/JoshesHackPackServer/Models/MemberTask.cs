
using System.ComponentModel.DataAnnotations;

namespace JoshesHackPack.Models 
{
	public class MemberTask
	{
		public int ID { get; set; }

		[Display(Name = "Member")]
		public int MemberID { get; set; }
		public Member Member { get; set; }

		[Display(Name = "Task")]
		public int TaskID { get; set; }
		public Task Task { get; set; }

		public string Status { get; set; }
	} 
}


