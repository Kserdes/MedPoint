
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
                            FullName = "lek. med. Michał Borkowski",
                            Specialization = "Lekarz rodzinny",
                            ProfilePictureURL = "https://www.evi-med.pl/wp-content/uploads/2019/02/Evimed_przychodnia_Gdynia_6.jpg",
                            
                        },
                        new Doctor()
                        {
                            FullName = "lek. med. Anna Klepacz",
                            Specialization = "Alergolog",
                            ProfilePictureURL = "https://naszarecepta.pl/wp-content/themes/naszarecepta/img/bn-contact.jpg",

                        },
                        new Doctor()
                        {
                            FullName = "lek. med. Joanna Wawrzak",
                            Specialization = "Okulista",
                            ProfilePictureURL = "https://i0.wp.com/sprawy-karne.biz.pl/wp-content/uploads/2017/03/39718746_l.jpg?fit=700%2C400&ssl=1",

                        },
                        new Doctor()
                        {
                            FullName = "dr n. med. Łukasz Zawadzki",
                            Specialization = "Dermatolog",
                            ProfilePictureURL = "https://polki.pl/work/privateimages/sources/we-dwoje/p/a_i/62/30/6/33598/b/b_1_33598.jpg",

                        },
                        new Doctor()
                        {
                            FullName = "lek. med. Anna Miśkiewicz",
                            Specialization = "Ginekolog",
                            ProfilePictureURL = "https://konsylium24.pl/assets/k24/zdjecie_lekarka-7a523239cfb0bcf0ba96d42968069640cdf676bd25c0ea8b1b63437a5670ffd1.png",

                        },
                        new Doctor()
                        {
                            FullName = "lek. med. Andrzej Fabijański",
                            Specialization = "Kardiolog",
                            ProfilePictureURL = "https://polki.pl/foto/4_3_LARGE/lekarz-w-nocy-jakie-przychodnie-przyjmuja-w-nocy-178801.jpg",

                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

