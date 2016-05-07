/************************************************************************ 
 * Projt Name  :  LearnMVC.DAL       
 * File Name   :  MyDBContext 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 2:56:39 PM 
 * Update Time :  5/6/2016 2:56:39 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/
using LearnMVC.Models;
using System.Data.Entity;

namespace LearnMVC.DAL
{
    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }

        public MyDBContext()
            : base("DefaultConnection")
        {
        }
    }
}
