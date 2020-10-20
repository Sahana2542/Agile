using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TrialConApp
{
    public class SerialTestarray
    {
        public void SerializeNow()
        {
            ClassToSerializeArray[] c = new ClassToSerializeArray[3];
            c[0] = new ClassToSerializeArray();
            c[0].Name = "bipin";
            c[0].Age = 26;
            c[1] = new ClassToSerializeArray();
            c[1].Name = "abc";
            c[1].Age = 75;
            c[2] = new ClassToSerializeArray();
            c[2].Name = "pqr";
            c[2].Age = 50;
            ClassToSerializeArray.CompanyName = "xyz";
            FileStream s = new FileStream("Demo.bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, c);
            s.Close();
        }
        public void DeSerializeNow()
        {
            ClassToSerializeArray[] c;
            FileStream s = new FileStream("Demo.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter b = new BinaryFormatter();
            c = (ClassToSerializeArray[])b.Deserialize(s);
            Console.WriteLine("Name :" + c[2].Name);
            Console.WriteLine("Age :" + c[2].Age);
            Console.WriteLine("Company Name :" + ClassToSerializeArray.CompanyName);
            s.Close();
        }
        public static void Main(string[] s)
        {
            SerialTest st = new SerialTest();
            st.SerializeNow();
            st.DeSerializeNow();
        }
    }
    public class ClassToSerializeArray
    {
        private int age;
        private string name;
        static string companyname;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public static string CompanyName
        {
            get
            {
                return companyname;
            }
            set
            {
                companyname = value;
            }
        }
    }
}