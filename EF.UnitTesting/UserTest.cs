using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EF.Data;
using EF.Core.Data;
using System.Data.Entity;
using System.Data;


namespace EF.UnitTesting
{
    [TestClass]
   public class UserTest
    {

        [TestMethod]
        public void UserUserProfileTest()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());
            using (var context = new EFDbContext())
            {
                context.Database.Create();
                User user = new User
                {
                    UserName = "codeslayer",
                    Password = "123",
                    Email = "frankellyveras@gmail.com",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    UserProfile = new UserProfile
                    {
                        FirstName = "Frankelly",
                        LastName = "Veras",
                        Address = "Sto.Dgo",
                        AddedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IP = "1.1.1.1"
                    },
                };
                context.Entry(user).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }  

    }
}
