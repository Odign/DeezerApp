using DeezerApp.Service.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeezerApp.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            OwinService service = new OwinService();
            service.Start();
            Console.WriteLine("Service hosted at: http://localhost:9000");
            Console.WriteLine("Songs service resource: http://localhost:9000/api/songs/{artistName}");
            Console.ReadLine();
        }
    }
}
