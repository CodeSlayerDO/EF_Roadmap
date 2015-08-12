using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Core.Data;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Data.Mapping
{
   public class OrderMap : EntityTypeConfiguration<Order>
    {

       public OrderMap()
       {
           //Key 
           HasKey(t => t.ID);

           //Properties
           Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(t => t.Quantity).IsRequired();
           Property(t => t.Price).IsRequired();
           Property(t => t.CustomerID).IsRequired();
           Property(t => t.AddedDate).IsRequired();
           Property(t => t.ModifiedDate).IsRequired();
           Property(t => t.IP);

           //table  
           ToTable("Orders");    

           //RelationShip
           HasRequired(t => t.Customer).WithMany(c => c.Orders).HasForeignKey(t => t.CustomerID).WillCascadeOnDelete(false);      
       
       
       }


    }
}
