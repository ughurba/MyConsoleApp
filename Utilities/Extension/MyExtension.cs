using System;
using Utilities.Helper;

namespace Utilities.Extension
{
    public static class MyExtension
    {
        public static string CheckCreate()
        {   EnterNameCreate:
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                bool num = false;

                bool num2 = false;


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
                if (num == true && num2 == true)
                {
                    return name;
                }
                else
                {
                    Helper.Extension.Print(ConsoleColor.Red, "Xeta!!\n1) Name minimum 4 herif olmalidi\n" +
                        "2)Icinde reqem olmali deyil\n");

                    goto EnterNameCreate;
                }
            }
            else
            {
                Helper.Extension.Print(ConsoleColor.Red, "bow ola bilmez ,zehmet olmasa duzgun daxil edin");
                goto EnterNameCreate;
            }

           



        }
        public static string CheckAdress()
        {
             EnterAdressCreate:
            string adress = Console.ReadLine();
            if (!string.IsNullOrEmpty(adress))
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
                    return adress;
                }
                else
                {
                    Helper.Extension.Print(ConsoleColor.Red, "Restoran acilmadi\n1)Restaurant adress minimum 4 herif olmalidi\n" +
                       "2)Icinde number olmalidir\n" +
                       "3)Bowluq olmalidi !!!\n");
                    goto EnterAdressCreate;

                }
            }
            else
            {
                Helper.Extension.Print(ConsoleColor.Red, "bow ola bilmez ,zehmet olmasa duzgun daxil edin");
                goto EnterAdressCreate;
            }


        }
        public static string CheckNull()
        {
            string name;
          
                EnterName:
                name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }
                else
                {
                    Helper.Extension.Print(ConsoleColor.Red, "bow ola bilmez ,zehmet olmasa duzgun daxil edin");
                    goto EnterName; 
                }

           
        }
        public static int CheckInt()
        {
            IntError:
            string str = Console.ReadLine();
            int num;
            if(int.TryParse(str, out num))
            {
                if(num < 0)
                {
                    Helper.Extension.Print(ConsoleColor.Red, "menfi ola bilmez");
                    goto IntError;
                }
                else
                {
                    return num;
                }
               
            }
            else
            {
                Helper.Extension.Print(ConsoleColor.Red, "Zehmet olmasa duzgun daxil edin");
                goto IntError;
            }
        }
        public static int CheckIntAge()
        {
            EnterAge:
            string str = Console.ReadLine();
            int num;
            int.TryParse(str, out num);
            if(num >= 18 && num <= 30)
            {
                return num;
            }
            else
            {
                Helper.Extension.Print(ConsoleColor.Red, "Age 18-30 arasi olmalidir");
                goto EnterAge;
            }
        }
    }
}
