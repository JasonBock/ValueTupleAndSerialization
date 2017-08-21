using System;
using ValueTupleAndSerialization.Serializer;

namespace ValueTupleAndSerialization.NETFramework
{
	class Program
	{
		static void Main(string[] args) =>
			Console.Out.WriteLine(ValueTupleSerializer.Roundtrip((1, 2)));
	}
}
