using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace newton_ovnprog1.Collections
{
    class coll_ovn1
    {
        
        public void printList()
        {
            
            ArrayList medical = new ArrayList();
            medical.Add("Sohail");
            medical.Add("52");
            medical.Add("175");
            medical.Add("26.4f");

            foreach (object med in medical)
            {
                Console.WriteLine($"{med}");
            }
            

        }
        public void printCollectionGenericEx()
        {
            List<int> Grocery = new List<int>();
            Grocery.Add(34);
            Grocery.Add(134);
            Grocery.Add(4);
            Grocery.Add(304);
            Grocery.Add(56);

            int sum = 0;
            foreach (int g in Grocery)
            {
                sum += g;
            }
            Console.Write($"Summan är: {sum}");

        }
        static public void printBoth()
        {
            coll_ovn1 col1 = new coll_ovn1();
            col1.printList();
            coll_ovn1 col2 = new coll_ovn1();
            col2.printCollectionGenericEx();
            
        }

    }
}
