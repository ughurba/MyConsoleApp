using System;
using Utilities.Helper;

namespace Utilities.Extension
{
    public static class MyExtension
    {
        public static bool CheckCreate(this string chek, string name)
        {
            bool num = false;
            bool num2 = false;
            bool num3 = false;

            for (int i = 0; i < name.Length; i++)
            {
                if (name.Length >= 4)
                {
                    num = true;
                }
                if (char.IsNumber(name[i]))
                {
                    num2 = false;
                    break;
                }
                else
                {
                    num2 = true;
                }
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsWhiteSpace(name[i]))
                {
                    num3 = false;
                    break;
                }
                else
                {
                    num3 = true;
                }
            }


            if (num == true && num2 == true && num3 == true)
            {
                return true;
            }
            else
            {
                Helper.Extension.Print(ConsoleColor.Red, "Restoran acilmadi\n1)Restaurant name minimum 4 herif olmalidi\n" +
                    "2)Icinde number olmali deyil\n" +
                    "3)Bowluq ola bilmez!!!\n");
                return false;
            }



        }
        public static bool CheckAdress(this string chek , string adress)
        {
            bool num = false;
            bool num2 = false;
            bool num3 = false;

            for (int i = 0; i < adress.Length; i++)
            {
                if (adress.Length >= 4)
                {
                    num = true;
                }
                if (char.IsNumber(adress[i]))
                {
                    num2 = true;
                }
               
            }

            for (int i = 0; i < adress.Length; i++)
            {
                if (char.IsWhiteSpace(adress[i]))
                {
                    num3 = true;
                    
                }
             
            }


            if (num == true && num2 == true && num3 == true)
            {
                return true;
            }
            else
            {
                 Helper.Extension.Print(ConsoleColor.Red, "Restoran acilmadi\n1)Restaurant adress minimum 4 herif olmalidi\n" +
                    "2)Icinde number olmalidir\n" +
                    "3)Bowluq olmalidi !!!\n");
                
                return false;
            }
        }
        public static bool CheckName(this string chek,string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsNumber(name[i]))
                {
                    Helper.Extension.Print(ConsoleColor.Red, "Name-de reqem ola bilmez!!!");
               
                    return false;
                }
              
            }
            return true;

        }

    }
}
