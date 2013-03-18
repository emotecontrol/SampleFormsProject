using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFormsProject
{
    class TestClass
    {
        
        BindingList<SampleObject> list1 = new BindingList<SampleObject>();
        public TestClass()
        {
            
            SampleObject test1 = new SampleObject()
            {
                string1 = "Hello",
                string2 = "World",
                bool1 = true,
                int1 = 56,
                int2 = 45,
                int3 = 33

            };
            SampleObject test2 = new SampleObject()
            {
                string1 = "Goodnight",
                string2 = "Moon",
                bool1 = false,
                int1 = 32,
                int2 = 66,
                int3 = 98

            };
            list1.Add(test1);
            list1.Add(test2);
        }
        public BindingList<SampleObject> List
        {
            get
            {
                return list1;
            }
            set
            {
                list1 = value;
            }

        }
        
    }
}
