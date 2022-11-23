using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesIntro
{
    class Info
    {
        private string _name;
        private string _message;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Info screen = new Info();

            Console.Write("Enter your name : ");
            screen.name = Console.ReadLine();
            Console.Write("Enter your message : ");
            screen.message = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < screen.message.Length; i++)
            {
                if (screen.message[i] == 'a' || screen.message[i] == 'e' || screen.message[i] == 'ı' || screen.message[i] == 'i' || screen.message[i] == 'o' || screen.message[i] == 'ö' || screen.message[i] == 'u' || screen.message[i] == 'ü')
                {
                    count++;
                }
            }

            Console.WriteLine("Sayın {0}, {1} adet sesli harf kullandınız.", screen.name, count);

            Console.WriteLine("Mesajınız: {0}", screen.message);

        }
    }
}
