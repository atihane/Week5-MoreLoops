﻿using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis kuvab konsool "Tere tulemast!"
            //muul juhul kuvab konsool "Vale kasutajatunnus või salasõna! Proovi uuesti!"

            //OR ||

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna! Proovi uuesti!");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
