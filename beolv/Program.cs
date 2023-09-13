using System;
//beolvasashoz az alabbi importott kell hasznalni
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace beolv{

    internal class Program{

        //main-en kivul letrehozzuk egy struct-urt es felveszuk a tarolni kivant adatokat
        //lehet class al is megoldani
        struct employees {
            //meg kell addni hogyan taroljuk a dollgozok adatait
            public int id;
            public string name;
            public double salary;
            public string city;
        }

        static void Main(string[] args){

            //letrehozunk egy listat
            //<mit tartalmaz a lista> utanna mi a neve a listanak
            List<employees> emp = new List<employees>();
            //letrehozunk egy olvasot majd az inicializalas utan megadjuk a file nak a nevet amit be akarunk olvasni
            StreamReader readFile = new StreamReader("emp.txt");
            //elso sor atlepese 
            readFile.ReadLine();

            //beolvasashoz szukseges ciklus
            do {
                //beolvasunk egy sort mar eltarolva
                string line = readFile.ReadLine();
                //letrehozunk egy uj tombot, split-el daraboljuk fel a sorokat es meg kell addni hogy mi az elvalaszto ';' (ide nem jo a "")
                string[] block = line.Split(';');

                //letre hozunk egy dolgozot
                employees newEmp = new employees{
                    //itt lesz a feltoltes
                    //at kell konvertalni a feltoltoltendo adatokat pl. int, double
                    id = int.Parse(block[0]),
                    name = block[1],
                    salary = double.Parse(block[2]),
                    city = block[3]
                  };
                //lista adas a listahoz
                emp.Add(newEmp);
                //be kell zarni a file beolvasast
                readFile.Close();

                Console.WriteLine("Dolgozok: ", emp);

            }
            //EndOfStream beolvasas vege, addig ismetlodik a ciklus ameddig van beolvasando file
            while (!readFile.EndOfStream);


        }
    }
}
