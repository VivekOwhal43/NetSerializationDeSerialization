using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDeSerialization
{
    public class BinarySerialization
    {
        public void BSerialization()            // method for writing details in txt file
        {
            Demo sample = new Demo();           // boject of serializable class
            FileStream fileStream = new FileStream(@"/home/vivek/bridgelabz/NetSerializationDeSerialization/SerializationDeSerialization/MyFile.txt",FileMode.Create);      // creating file in a specified directory
            BinaryFormatter formatter = new BinaryFormatter();      // creating object of BinaryFormatter Class
            formatter.Serialize(fileStream,sample);
        }
    }

    [Serializable]
    public class Demo       // demo class for creating veriables for getting application name and id
    {
        public string ApplicationName {get;set;} = "Binary Serialize";      // setting value mannually
        public int ApplicationId {get;set;} = 1234;                     // setting id mannualy
    }
}