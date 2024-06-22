using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementLibrary
{
    public class StudentSortedList
    {
        SortedList list = new SortedList();
        public StudentSortedList()
        {
            list.Add(1, "Pallavi");
            list.Add(2, "Ankita");
            list.Add(13, "Amit");
            list.Add(4, "Jack");
            list.Add(5, "Jim");
        }

        public void AddStudent(int k, string v)
        {
            list.Add(k, v);
        }
        public void display()
        {
            foreach (DictionaryEntry item in list) 
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
