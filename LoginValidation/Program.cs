﻿using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on kolm katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
                }
                if (i == 3)
                {
                    Console.WriteLine("Oled sisestanud kasutajanime või parooli 3 korda valesti. Katsed on läbi.");
                }
            }
        }
    }
}

