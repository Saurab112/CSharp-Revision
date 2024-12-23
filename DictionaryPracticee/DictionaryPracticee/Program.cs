using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPracticee
{
	public class Program
	{
		static void Main(string[] args)
		{
			Dictionary<int, string> student = new Dictionary<int, string>()
			{
				{1, "ram" },
				{2, "saurab" },
				{3, "atul" },
				{4, "arav" }
			};

			foreach(KeyValuePair<int, string> kvp in student)
			{
				Console.WriteLine(kvp.Key + " " + kvp.Value);
			}
			//only keys
			Dictionary<int, string>.KeyCollection key = student.Keys;

			//prints value only
			Dictionary<int, string>.ValueCollection value = student.Values;
			foreach(var v in value)
			{
				Console.WriteLine(v);
			}

			//add
			student.Add(5, "abin");
			student.Remove(4);

			//check if contains key
			bool isContains = student.ContainsKey(1);
			Console.WriteLine("CointainsKey: " + isContains);

			//similar for ContainsValue(value)

			//clearing dictionary
			student.Clear();
		}
	}
}
