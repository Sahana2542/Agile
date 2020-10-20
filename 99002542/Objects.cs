using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
public class SerialTestObject
{
    public void SerializeNow()
    {
        ClassToSerialize c = new ClassToSerialize();
        c.Name = "bipin";
        c.Age = 26;
        ClassToSerialize.CompanyName = "xyz";
        FileStream s = new FileStream("Demo.bin", FileMode.OpenOrCreate, FileAccess.Write);
        BinaryFormatter b = new BinaryFormatter();
        b.Serialize(s, c);
        s.Close();
    }
    public void DeSerializeNow()
    {
        ClassToSerialize c = new ClassToSerialize();
        FileStream s = new FileStream("Demo.bin", FileMode.Open, FileAccess.Read);
        BinaryFormatter b = new BinaryFormatter();
        c = (ClassToSerialize)b.Deserialize(s);
        Console.WriteLine("Name :" + c.Name);
        Console.WriteLine("Age :" + c.Age);
        Console.WriteLine("Company Name :" + ClassToSerialize.CompanyName);
        Console.WriteLine("Company Name :" + c.GetSupportClassString());
        s.Close();
    }
    public static void Main(string[] s)
    {
        SerialTestObject st = new SerialTestObject();
        st.SerializeNow();
        st.DeSerializeNow();
    }
}
public class ClassToSerialize
{
    private int age;
    private string name;
    static string companyname;
    SupportClass supp = new SupportClass();
    public ClassToSerialize()
    {
        supp.SupportClassString = "In support class";
    }
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
    public string GetSupportClassString()
    {
        return supp.SupportClassString;
    }
}
public class SupportClass
{
    public string SupportClassString;
}