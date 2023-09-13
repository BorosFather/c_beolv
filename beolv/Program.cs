using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//beolvasashoz az alabbi importott kell hasznalni
using System.Collections.Generic;
using System.IO;

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
            StreamReader readFile = new StreamReader("emp");

        }
    }
}
