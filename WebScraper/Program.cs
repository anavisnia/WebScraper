﻿using ScrapySharp.Network;
using System;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
            2. Parašyti WebScraper konsolinę programą, kuri išspausdina darbo skelbimų pavadinimus (pavyzdžiui: 'Technical Writer')
            iš https://www.cvonline.lt/darbo-skelbimai/informacines-technologijos pirmojo puslapio.
            Patarimas: Instaliuokite, panaudokite 'HTMLAgilityPack Nuget package' savo programoje.
         */


            ScrapingBrowser browser = new ScrapingBrowser();

            WebPage homePage = browser.NavigateToPage(new Uri("https://www.cvonline.lt/lt/search?limit=20&offset=0&categories%5B0%5D=INFORMATION_TECHNOLOGY&isHourlySalary=false&isRemoteWork=false"));


        }
    }
}
