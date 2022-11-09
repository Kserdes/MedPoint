
using MedPoint.Models;
using System;

namespace MedPoint.Data
{
    public class AppDBSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();


                if (!context.Doctors.Any())
                {
                    context.Doctors.AddRange(new List<Doctor>()
                    {
                        new Doctor()
                        {
                            FullName = "Michał Borkowski",
                            Specialization = "Lekarz rodzinny",
                            ProfilePictureURL = "https://www.evi-med.pl/wp-content/uploads/2019/02/Evimed_przychodnia_Gdynia_6.jpg",
                            
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

