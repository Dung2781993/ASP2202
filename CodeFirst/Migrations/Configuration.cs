namespace CodeFirst.Migrations
{
    using CodeFirst.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CodeFirst.DAL.SchoolContext";
        }

        protected override void Seed(CodeFirst.DAL.SchoolContext context)
        {
            
        }
    }
}
