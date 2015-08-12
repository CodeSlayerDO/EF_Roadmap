using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EF.Core.Data;


namespace EF.Data.Mapping
{
    class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {

        public UserProfileMap() 
        {
            //key
            HasKey(t => t.ID);

            //fields  
            
            Property(t => t.FirstName);
            Property(t => t.LastName);
            Property(t => t.Address).HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.AddedDate);
            Property(t => t.ModifiedDate);
            Property(t => t.IP); 
            
            //Table
            ToTable("UserProfiles");

            //relationship  
            HasRequired(t => t.User).WithRequiredDependent(u => u.UserProfile);
        
        
        }

    }
}
