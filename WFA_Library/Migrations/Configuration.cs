namespace WFA_Library.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WFA_Library.Context.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WFA_Library.Context.MyContext context)
        {
            //DB doldurma için kullanılacak seed metodu buraya yazılır.
        }
    }
}
