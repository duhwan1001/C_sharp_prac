using System;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Person
{
	[NonSerialized]
	public int Age;
	public string Name;

	public Person(int age, string Name)
	{
		this.Age = age;
		this.Name = Name;
	}

	public override string ToString()
	{
		return string.Format("{0} {1}", this.Age, this.Name);
	}
}

public class serializable
{
	static void Main(string[] args)
	{
		Person person = new Person(36, "Anderson");

		BinaryFormatter bf = new BinaryFormatter();

		// 직렬화
		MemoryStream ms = new MemoryStream();
		bf.Serialize(ms, person);

		ms.Position = 0;
		
		// 역직렬화
		Person clone = bf.Deserialize(ms) as Person;
		Console.WriteLine(clone);
	}
	
}
