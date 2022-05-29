using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3Apsio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DeletedData();
            InsertDataMedicament();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        public static void DeletedData()
        {
            var DbContext = new MyDbContext();
            DbContext.Medicaments.RemoveRange(DbContext.Medicaments);
            DbContext.Santes.RemoveRange(DbContext.Santes);
            DbContext.SaveChanges();

        }
        public static void InsertDataMedicament()
        {
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\shaah\OneDrive\Bureau\Mission3CSV\run_results.csv"))
            { 
                var DbContext = new MyDbContext();
                
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    Medicament med = new Medicament();
                    
                    //Processus Du read dans le fichier
                    string[] fields = parser.ReadFields();
                    med.id = fields[0].ToString();
                    med.Titre = fields[1].ToString();
                    med.Url = fields[2].ToString();
                    med.prix = fields[3].ToString();
                    med.informations = fields[4].ToString();
                    
                    DbContext.Medicaments.Add(med);
                }

                DbContext.SaveChanges();
            }

            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\shaah\OneDrive\Bureau\Mission3CSV\run_results2.csv"))
            {
                var DbContext = new MyDbContext();

                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    Sante sant = new Sante();

                    //Processus Du read dans le fichier
                    string[] fields = parser.ReadFields();
                    sant.id = fields[0].ToString();
                    sant.Titre = fields[1].ToString();
                    sant.Url = fields[2].ToString();
                    sant.prix = fields[3].ToString();
                    sant.informations = fields[4].ToString();

                    DbContext.Santes.Add(sant);
                }

                DbContext.SaveChanges();
            }
        }
    }
}
