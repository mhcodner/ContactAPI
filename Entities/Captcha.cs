using System.Collections.Generic;

namespace ContactAPI.Entities
{
	public class Captcha
	{
        public string Id { get; set; }
		public string Question { get; set; }
		public List<string> Answers { get; set; }
	}
}