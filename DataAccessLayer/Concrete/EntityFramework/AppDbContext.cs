
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class AppDbContext : DbContext //Burada Sınıflarımı DbContext yardımıyla sql'e kaydediyorum
    {
        //Apointment tablosunu temsil eder
        public DbSet<Apointment> Apointments { get; set; }
        //Doctor tablosunu temsil eder
        public DbSet<Doctor> Doctors { get; set; }
        //Patient tablosunu temsil eder
        public DbSet<Patient> Patients { get; set; }
        //Category tablosunu temsil eder
        public DbSet<Category> Categories { get; set; }
        //Secretary tablosunu temsil eder
        public DbSet<Secretary> secretaries { get; set; }
        //Meet tablosunu temsil eder
        public DbSet<Meet> Meets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Veritabanı bağlantısının yapıldığı kod parçası
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-1DGG4KIM\\SQLEXPRESS;Initial Catalog=RandevuSistemi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


    }
}
