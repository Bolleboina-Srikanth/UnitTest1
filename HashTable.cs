using System;
using System.Collections;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashTable
    {
        public static void Main()
        {
            Hashtable h = new Hashtable();
            h.Add("name", "sri");
            h.Add("Rollno", 2);
            h.Add("email", "sri@");
            h.Add(36, "houseno");
            foreach(DictionaryEntry o in h)
            {
                Console.WriteLine($"key:-{o.Key} Value:-{o.Value}");
                Console.ReadLine();
            }
        }
    }
}
