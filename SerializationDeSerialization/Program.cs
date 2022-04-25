namespace SerializationDeSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization binarySerialization = new BinarySerialization();        // creating object of BinarySerialization class that we have created.
            binarySerialization.BSerialization();                       // calling method for Serialization
            binarySerialization.BinDeSerialization();                   // Calling method for DeSerialization
        }
    }
}