using EF.Core.Data;
using EF.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.UnitTesting
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CustomerOrderTest()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());
            using (var context = new EFDbContext())
            {
                context.Database.Create();
                Customer customer = new Customer
                {
                    Name = "Frankelly",
                    Email = "frankellyveras@gmail.com",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    Orders = new List<Order>{  
                                            new Order  
                                            {  
                                                Quantity = 12,  
                                                Price =15,  
                                                AddedDate = DateTime.Now,  
                                                ModifiedDate = DateTime.Now,  
                                                 IP = "1.1.1.1",  
                                            },  
                                            new Order  
                                            {  
                                                Quantity = 10,  
                                                Price =25,  
                                                AddedDate = DateTime.Now,  
                                                ModifiedDate = DateTime.Now,  
                                                 IP = "1.1.1.1",  
                                            }  
                                        }
                };
                context.Entry(customer).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }
    }  
}
