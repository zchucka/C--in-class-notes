using System;
using System.Collections.Generic;
using System.Text;

namespace LamdaDemo
{
	using System;
	using System.Linq;
	using System.Collections.Generic;

	public class Data
	{
		public int Id { get; set; }
		public string Country { get; set; }
		public string Currency { get; set; }
	}
	public class LambdaParam
	{
		public static void Main()
		{
			var records = new List<Data>(){ new Data {Id = 1, Country = "India", Currency = "INR"},
										new Data {Id = 1, Country = "India", Currency = "INR"},
										new Data {Id = 2, Country ="America", Currency = "Dollar"},
									  	new Data {Id = 1, Country = "India", Currency = "INR"},
										new Data {Id = 2, Country ="America", Currency = "Dollar"}
									  };

			var query = records.Where(x => x.Country == "India" && x.Currency == "INR").ToList();
			Console.WriteLine(query.Count());

			query.ForEach(q => {
				Console.WriteLine(q.Country);
			});

		}
	}
}
