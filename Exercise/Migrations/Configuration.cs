namespace Exercise.Migrations
{
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exercise.ExerciseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exercise.ExerciseContext context)
        {
            //context.Videos.AddOrUpdate(a => a.Name,
            //    new Video { Name = "DoggyDogg",
            //    ReleaseDate = DateTime.Now,
            //        Genres = new Collection<Genre>()
            //    { Genre.);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
