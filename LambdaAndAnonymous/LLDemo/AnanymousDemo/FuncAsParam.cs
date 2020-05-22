using System;
namespace AnanymousDemo
{ 
	//Ananymous function
	public class FuncParamProgram
	{
		public static void Main()
		{
			Console.WriteLine("Save Record Example");
			var record = SaveRecord(() => {
				var myRecord = new MyRecord() { Id = 1, Name = "xpto" };
				return myRecord;
			}
					  );
			Console.WriteLine(record.ToString());

		}



		public static MyRecord SaveRecord(Func<MyRecord> init)
		{
			var record = init();
			record.Created = DateTime.Now;
			return record;
		}
	}

	public class MyRecord
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Created { get; set; }

		public override string ToString()
		{
			return string.Format("Name {0} created on {1} with Id {2}.", this.Name, this.Created, this.Id);
		}
	}

}