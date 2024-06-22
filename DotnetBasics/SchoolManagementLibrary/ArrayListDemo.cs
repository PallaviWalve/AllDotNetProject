using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementLibrary
{
    public class ArrayListDemo
    {
        ArrayList arraylist = new ArrayList(4);

        public ArrayListDemo()
        {
            arraylist.Add(101);
            arraylist.Add(10.14f);
            arraylist.Add(132.324d);
            arraylist.Add(new DateTime(2024,12,13));
            arraylist.Add("Hello");
        }

        public ArrayList GetTheArrayList()
        {
                return arraylist;
        }
        public void AddElement(object obj)
        {
            //arraylist.Add(obj); //add at the end of the list

            arraylist.Insert(4, obj);//add at the specified index

            ArrayList a1 = new ArrayList(5);
            a1.Add(101);
            a1.Add(102);
            a1.Add(103);
            a1.Add(104);
            a1.Add(105);

            arraylist.AddRange(a1); //add the element at end of the 1st arraylist
            arraylist.InsertRange(3,a1); //add range from given index
        }
    }
}
