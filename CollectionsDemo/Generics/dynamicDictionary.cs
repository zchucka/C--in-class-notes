using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class dynamicDictionary
    {
		public static void dynamicDictionaryMain()
		{
			Dictionary<string, dynamic> Dict = new Dictionary<string, dynamic>();
			Dict.Add("String Response: ", new Response<string>() { Success = true, StatusCode = 200, Data = "{ foo: \"bar\" }" });
			Dict.Add("Decimal Response: ", new Response<decimal?>() { Success = true, StatusCode = 200, Data = 19.99M });
			Dict.Add("DateTime Response: ", new Response<DateTime>() { Success = true, StatusCode = 200, Data = DateTime.Now });

			foreach (KeyValuePair<string, dynamic> pair in Dict)
			{
				Console.WriteLine(pair.Key.ToString() + pair.Value.Data);
			}
		}
	}
	public class Response<T>
	{
		public bool Success { get; set; }
		public int StatusCode { get; set; }
		public T Data { get; set; }
	}
}
