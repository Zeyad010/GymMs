using GymMs.Models;
using Microsoft.EntityFrameworkCore;

namespace GymMs.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
                

        }


        public DbSet<UserM> TbUsers { get; set; }
        public DbSet<EmployeesM> TbEmployees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<UserM>().HasData(
                
                new UserM { ID=0124 ,Name="Yousef Mohamed",Gander="Male",Age=22,Email="yousefmo@gmail.com",Password="Yo1234",Phone="0100123456" ,SubscriptionPlan= "Platinum" },
                new UserM { ID = 0224, Name = "Ali Mohamed", Gander = "Male", Age = 27, Email = "alimomo@gmail.com", Password = "ali1234", Phone = "0100169456", SubscriptionPlan = "Platinum" },
                new UserM { ID = 0324, Name = "Layla Ahmed", Gander = "Female", Age = 23, Email = "laylaqn@gmail.com", Password = "lili1234", Phone = "0100128756", SubscriptionPlan = "Gold" },
                new UserM { ID = 0424, Name = "Nada Zein  ", Gander = "Female", Age = 25, Email = "nadaazein@gmail.com", Password = "Na1234", Phone = "0100119456", SubscriptionPlan = "VIP" }



                );


            modelBuilder.Entity<EmployeesM>().HasData(


                new EmployeesM
                {
                    ID=111 ,
                    Name="Momen Maher",
                    Gander="Male",
                    Age=26,
                    Email="momen@gmail.com",
                    Password="Mo1234",
                    Phone="0100123776" ,
                    Job="Trainer"



                },
                 new EmployeesM
                 {
                     ID = 1112,
                     Name = "Ahmed Ali",
                     Gander = "Male",
                     Age = 24,
                     Email = "ainforma@gmail.com",
                     Password = "aan1234",
                     Phone = "0100124476",
                     Job = "Trainer"



                 },
                  new EmployeesM
                  {
                      ID = 113,
                      Name = "Kamilya Nader",
                      Gander = "Female",
                      Age = 25,
                      Email = "kkkn@gmail.com",
                      Password = "k1234",
                      Phone = "0100333776",
                      Job = "Trainer"



                  }




                );



        }


    }
}
