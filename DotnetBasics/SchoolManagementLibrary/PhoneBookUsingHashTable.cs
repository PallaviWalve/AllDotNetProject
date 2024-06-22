using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;

namespace SchoolManagementLibrary
{
    public class PhoneBookUsing_HashTable
    {
        Hashtable ht = new Hashtable();
        public void populateEntries()
        {
           
            ht.Add(78546963, "Pallavi");
            ht.Add(88546963, "Shreya");
            ht.Add(98546963, "Monika");
            ht.Add(898546963, "Chetana");
            ht.Add(858546963, "Shrushti");

            foreach (DictionaryEntry item in ht) 
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        public void AddData(int k, string v) 
        {
            ht.Add(k, v);
        }

        public string FindName(int key)
        {
            string name = (string) ht[key];
            return name;
        }

        public void display()
        {
           foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
