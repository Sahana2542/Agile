using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TrialConApp
{
    public class SerialTest
    {
        public void SerializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            FileStream fs = new FileStream("Demo.bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fs, c);
            fs.Close();
        }
        public void DeSerializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            FileStream fs = new FileStream("Demo.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            c = (ClassToSerialize)b.Deserialize(fs);
            Console.WriteLine(c.name);
            fs.Close();
        }
        public static void Main(string[] s)
        {
            SerialTest st = new SerialTest();
            st.SerializeNow();
            st.DeSerializeNow();
        }
    }
    public class ClassToSerialize
    {
        public int age = 100;
        public string name = "bipin";
    }
}