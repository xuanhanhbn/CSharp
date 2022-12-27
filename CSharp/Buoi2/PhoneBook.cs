using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CShap.BaiTap2
{
    internal class PhoneBook : Phone
    {


        List<string> PhoneList = new List<string>();


        

        public override void InsertPhone(string name, string phone)
        {
            bool isName = PhoneList.Contains(name);
            bool isPhone = PhoneList.Contains(phone);
            if (isName == false)
            {
                PhoneList.Add("Name: " + name + " | " + "Phone: " + phone + "\n");
            }else
            {
                if(isPhone == true)
                {
                    Console.WriteLine(">>>>Liên hệ đã tồn tại...");
                }else
                {
                    int Index = PhoneList.IndexOf(name);
                    PhoneList.Insert(Index + 1,", " + phone);
                }
            }
        }

        public override void RemovePhone(string name)
        {
            foreach (string item in PhoneList)
            {
                Console.Write(" " + item);
            }

        }

        public override void SearchPhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void Sort()
        {
            
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override void UpdatePhone(string name, string newphone)
        {
            
        }
    }
}
