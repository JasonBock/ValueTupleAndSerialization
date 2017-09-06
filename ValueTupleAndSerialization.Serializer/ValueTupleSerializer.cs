using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ValueTupleAndSerialization.Serializer
{
	public static class ValueTupleSerializer
	{
		// Note: https://github.com/dotnet/corefx/issues/15229
		public static (int, int) Roundtrip((int, int) value)
		{
			var formatter = new BinaryFormatter();

			using (var stream = new MemoryStream())
			{
				formatter.Serialize(stream, value);
				stream.Position = 0;
				return ((int, int))formatter.Deserialize(stream);
			}
			//	var isSerializable = value.GetType().IsSerializable;

			//Console.Out.WriteLine(isSerializable);

			//if(isSerializable)
			//{
			//	var formatter = new BinaryFormatter();
				
			//	using (var stream = new MemoryStream())
			//	{
			//		formatter.Serialize(stream, value);
			//		stream.Position = 0;
			//		return ((int, int))formatter.Deserialize(stream);
			//	}
			//}
			//else
			//{
			//	throw new SerializationException($"Cannot serialize {value.GetType().Name}");
			//}
		}
	}
}
