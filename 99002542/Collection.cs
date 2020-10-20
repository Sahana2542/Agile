using System;
using System.Collections.Generic;
using System.Linq;
namespace TrialConApp
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public override int GetHashCode()
        {
            return EmpID.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee temp = obj as Employee;
                return this.EmpID == temp.EmpID;
            }
            return false;

        }
    }
    class CollectionExample
    {
        static void Main(string[] args)
        {
            //ListExample();
            //hashsetExample();
            //hashsetOnobjects();
            //DictionaryExample();
            //QueueExample();

        }

        private static void hashsetOnobjects()
        {
            HashSet<Employee> data = new HashSet<Employee>();

            data.Add(new Employee { EmpID = 123, EmpName = "Phaniraj" });
            if (data.Add(new Employee { EmpID = 123, EmpName = "Phaniraj" }))
                Console.WriteLine("added");
            else
                Console.WriteLine("duplicate");
            data.Add(new Employee { EmpID = 123, EmpName = "Phaniraj" });
            data.Add(new Employee { EmpID = 123, EmpName = "Phaniraj" });
            Console.WriteLine("Data Count: " + data.Count);
        }

        private static void QueueExample()
        {
            Queue<string> recentItems = new Queue<string>();
            do
            {
                string item = MyConsole.getString("Enter the Item to view");
                if (recentItems.Count == 3)
                    recentItems.Dequeue();//Removes the first item in the queue.
                recentItems.Enqueue(item);
                Console.WriteLine("Ur recently viewed items:");
                var iterator = recentItems.Reverse();
                foreach (string obj in iterator)
                    Console.WriteLine(obj);
            } while (true);
        }

        private static void DictionaryExample()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            bool adding = true;
            do
            {
            Tryagain:
                string username = MyConsole.getString("Enter a Username for UR login");
                string pwd = MyConsole.getString("Enter the Password");
                if (users.ContainsKey(username))
                {
                    Console.WriteLine("User already exists\nPlease try again");
                    goto Tryagain;
                }
                else
                {
                    users[username] = pwd;
                }
                string choice = MyConsole.getString("Press A to add or any key to leave");
                adding = choice.ToUpper() == "A" ? true : false;
            } while (adding);

            Console.WriteLine("Lets allow the user to log...");
            string uname = MyConsole.getString("Enter a Username for UR login");
            string upwd = MyConsole.getString("Enter the Password");
            if (users.ContainsKey(uname))
            {
                if (users[uname] == upwd)
                    Console.WriteLine("Welcome user!!!!");
                else
                    Console.WriteLine("Password is wrong!!!!");
            }
            else
                Console.WriteLine("user name is wrong!!!!");
        }

        private static void hashsetExample()
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Apple");
            set.Add("Mango");
            set.Add("Orange");
            set.Add("Apple");    
            set.Add("Apple");
            Console.WriteLine("The size is " + set.Count);
        }

        private static void ListExample()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple"); 
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("PineApple");
            fruits.Remove("Orange");
            foreach (var item in fruits) Console.WriteLine(item);

            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}