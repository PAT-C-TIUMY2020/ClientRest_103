﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClientRest_20180140103_Rama_Soni_Ravictor
{
    class ClassData
    {
        public void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach (var mhs in data)
            {
                Console.WriteLine("Nama: " + mhs.nama);
                Console.WriteLine("NIM: " + mhs.nim);
                Console.WriteLine("Prodi: " + mhs.prodi);
                Console.WriteLine("Angkatan: " + mhs.angkatan);
            }
            Console.ReadLine();
        }
    }
}
