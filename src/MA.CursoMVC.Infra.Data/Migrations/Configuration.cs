﻿using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MA.CursoMVC.Infra.Data.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<MA.CursoMVC.Infra.Data.Context.CursoMVCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MA.CursoMVC.Infra.Data.Context.CursoMVCContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
