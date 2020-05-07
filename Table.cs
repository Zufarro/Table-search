using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{

   public class Element
    {
        public int key;
        public string value;
        public Element next;

        public Element(int k, string val)
        {
            key = k;
            value = val;
            next = null;
        }
    }
    class Hash_Table
    {
        static int Size = 37;
        Element[] T = new Element[Size];
        string Mess;

        public Hash_Table()
        {
            for (int i = 0; i < 37; i++)
                T[i] = null;
        }

        int Hash(int key)
        {
            return key % 37;
        }

        public void Insert(int ikey, string ival)
        {
            int H = Hash(ikey);
            Element ielem = new Element(ikey, ival);
            Element NElem =T[H];
            if (T[H] == null)
                T[H] = ielem;
            else
            {
                if(NElem.key == ikey)
                {
                    NElem.value = ival;
                    return;
                }
                while (NElem.next != null)
                {
                    FindNext(NElem, ref NElem);
                    if (NElem.key == ikey)
                    {
                        NElem.value = ival;
                        return;
                    }
                }
                    NElem.next = ielem;
            }
        }

        void FindNext(Element current, ref Element next)
        {
            next = current.next;
        }
        public void Delete(int ikey)
        {
            int H = Hash(ikey);
            Element NElem = T[H];
            Element temp;
            Element parent;

            if (T[H] == null)
                Mess = "Сan not delete. Key not found";
            else
            {
                if (NElem.key == ikey)
                {
                    temp = T[H];
                    T[H] = T[H].next;
                    temp = null;
                    Mess = "Successfully deleted";
                    return;
                }
                while (NElem.next != null)
                {
                    parent = NElem;
                    FindNext(NElem, ref NElem);
                    if (NElem.key == ikey)
                    {
                        parent.next = NElem.next;
                        NElem = null;
                        Mess = "Successfully deleted";
                        return;
                    }
                }

            }
        }
        
        public void  Search_hash(int ikey)
        {
            int H = Hash(ikey);
            Element NElem = T[H];
            Element temp;
            Element parent;

            if (T[H] == null)
                Mess = "Element not found";
            else
            {
                if (NElem.key == ikey)
                {
                    Mess = NElem.key.ToString() + " " + NElem.value;
                    return;
                }
                while (NElem.next != null)
                {
                    FindNext(NElem, ref NElem);
                    if (NElem.key == ikey)
                    {
                        Mess = NElem.key.ToString() + " " + NElem.value;
                        return;
                    }
                }

            }
        }

        public string GetMess()
        {
            return Mess;
        }


        public void Print(System.Windows.Forms.TextBox tbResult)
        {
            tbResult.Clear();
            for (int i = 0; i < Size; i++)
            {
                if (T[i]!=null)
                {
                    Element NElem = T[i];
                    tbResult.AppendText(NElem.key.ToString() + " " + NElem.value + Environment.NewLine);
                    while (NElem.next != null)
                    {
                        FindNext(NElem, ref NElem);
                        tbResult.AppendText(NElem.key.ToString() + " " + NElem.value + Environment.NewLine);
                    }
                }

            }
        }


    }

    class Sorted_Table
    {
        static int Size = 37;
        Element[] T = new Element[Size];
        int num = 0;
        string Mess;

        public void InsertSorted(int key, string value)
        {

            if (num >= Size)
                return;
            int index = Search_half_division(0, num - 1, key);
            if(index != -1)
            {
                T[index].value = value;
                return;
            }
            int i;
            for (i = num - 1; (i >= 0 && T[i].key > key); i--)
                T[i + 1] = T[i];

            T[i + 1] = new Element(key, value);
            num++;
        }

        public int GetNum()
        {
            return num;
        }
        public int Search_half_division(int low, int high, int key)
        {
            if (high < low)
            {
                Mess = "Element not found";
                return -1;
            }

            int mid = (low + high) / 2;

            if (key == T[mid].key)
            {
                Mess = T[mid].key.ToString() + " " + T[mid].value;
                return mid;
            }

            if (key > T[mid].key)
                return Search_half_division((mid + 1), high, key);

            return Search_half_division(low, (mid - 1), key);
        }

        public string GetMess()
        {
            return Mess;
        }

         public void Delete(int key)
        {
            // Find position of element to be deleted 
            
            int pos = Search_half_division(0, num - 1, key);

            if (pos == -1)
            {
                Mess = "Element not found";
                return;
            }

            // Deleting element 
            int i;
            for (i = pos; i < num - 1; i++)
                T[i] = T[i + 1];

            num--;
        }

        public void Search_brute_force(int k)
        {
            for (int i = 0; i < num; i++)
            {
                if (T[i].key == k)
                {
                    Mess = T[i].key.ToString() + " " + T[i].value;
                    return;
                }
            }
            Mess = "Element not found";
        }

    }
}
