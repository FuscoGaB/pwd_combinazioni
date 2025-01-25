using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bf_banca_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            banca UBI = new banca();
            string pwd = "Ci@";
            string pwd1 = "i@o";
            bool trovato = false;
            string pass = "";
            DateTime a = DateTime.Now;
            for (int i = 0; i < 256; i++)
            {
                pwd = pwd.Substring(0,3) + (char)i;
                if (UBI.Login(pwd))
                {
                    trovato = true;
                    pass = pwd1 + pwd;
                }
            }
            for (int i = 0; i < 256; i++)
            {
                pwd1 = (char)i + pwd1.Substring(1, 4);
                if (UBI.Login(pwd1))
                {
                    trovato = true;
                    pass = pwd1 + pwd;
                }
            }
            DateTime b = DateTime.Now;
            Console.WriteLine(b.Subtract(a).TotalMilliseconds);
            if (trovato)
            Console.WriteLine("Password : "+pass);
            Console.ReadKey();
        }
    }
}
