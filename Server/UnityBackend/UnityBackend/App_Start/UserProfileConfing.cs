using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using UnityBackend.Models;

namespace UnityBackend.App_Start
{
    public class UserProfileConfing:EntityTypeConfiguration<UserProfileModel>
    {
        public UserProfileConfing():base() 
        {
            HasKey(p => p.UserName);
            ToTable("UserProfile");
        
        }


    }
}