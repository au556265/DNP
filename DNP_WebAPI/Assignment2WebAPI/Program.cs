using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2WebAPI.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Assignment2WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (DataContext dataContext = new DataContext())
            {
              
            }
            CreateHostBuilder(args).Build().Run();
        }

   

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}