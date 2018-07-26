using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Heranca_PAD
{
     class Manager
    {
        //Class References (Instance of objects);
        BankAccount account = new BankAccount();
        
        public void MenuSystem()
        {
            //variveis;
            int a = 0;
            int listNumber = 0;

            string[,] texts = new string[,] {
            {"-->","   ",  "   "},
            {"[Login]","[Create an account]","[Quit]"}};

            //variaveis de validade;
            bool validesup = true;
            bool validesdo = true;

            while (a == 0)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Bem-Vindo ao BANCO SBB\n");

                for (int c = 0; c < 3; c++)
                {
                    for (int l = 0; l < 2; l++)
                    {
                        Console.Write(texts[l, c]);
                    }
                    Console.WriteLine();
                }

                ConsoleKeyInfo input = Console.ReadKey();
                //Seletor:
                if (listNumber == 0)
                {
                    validesdo = true;
                    validesup = false;
                }
                else if (listNumber > 0 && listNumber < 2)
                {
                    validesup = true;
                    validesdo = true;
                }
                else if (listNumber == 2)
                {
                    validesdo = false;
                    validesup = true;
                }

                int contadorLimpesa = 0;

                if (input.Key == ConsoleKey.UpArrow && validesup == true)
                {
                    while (contadorLimpesa < 3)
                    {
                        texts[0, contadorLimpesa] = "   ";
                        contadorLimpesa++;
                    }
                    listNumber--;
                    texts[0, listNumber] = "-->";
                }
                else if (input.Key == ConsoleKey.DownArrow && validesdo == true)
                {
                    while (contadorLimpesa < 3)
                    {
                        texts[0, contadorLimpesa] = "   ";
                        contadorLimpesa++;
                    }
                    listNumber++;
                    texts[0, listNumber] = "-->";
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    switch (listNumber)
                    {
                        case 0:
                            Login();
                            break;
                        case 1:
                            CreateAccount();
                            break;
                        case 2:
                            Quit();
                            break;
                        default:
                            Console.WriteLine("Error in variable: listNumber = {0}", listNumber);
                            Console.ReadKey();
                            break;
                    }
                    break;
                }
                Console.Clear();
            }//end While;

        }//end Menu;

        private void Login()
        {
            //Variables;
            string name;
            int password;
            char[] characters = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '@','#', '$', '%',
                                            '¨', '&', '*', '(', ')', '_', '-', '+', '=', '§', '[', ']', '{', '}', 'ª', 'º',
                                            '/', '.', ',', '|'};
            bool validade = false;

            while (validade == false)
            {
                Console.Write("Digite seu nome (completo):");
                name = Console.ReadLine();

                for (int i = 0; i < characters.Length; i++)
                {

                }

                Console.WriteLine();
            }

            Console.WriteLine("Login");
            Console.ReadKey();
        }//end Login;
        private void CreateAccount()
        {
            Console.WriteLine("Create an account");
            Console.ReadKey();
        }//end CreateAccount;
        private void Quit()
        {
            Console.WriteLine("Quit...");
            Console.ReadKey();
        }//end Quit;
    }
}
