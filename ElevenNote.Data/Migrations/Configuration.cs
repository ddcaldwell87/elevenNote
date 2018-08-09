namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ElevenNote.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ElevenNote.Data.ApplicationDbContext";
        }

        protected override void Seed(ElevenNote.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var notes = new List<Note>
            {
                new Note{Title = "A Seeded Note", Content = "Lorum ipsum blah blah", OwnerID = Guid.NewGuid(), CreatedUtc = new DateTimeOffset()},
                new Note{Title = "Another Seeded Note", Content = "Lorum ipsum blah dee do da", OwnerID = Guid.NewGuid(), CreatedUtc = new DateTimeOffset()},
                new Note{Title = "A Seeded Note", Content = "Lorum ipsum blah blah blabber dee blah", OwnerID = Guid.NewGuid(), CreatedUtc = new DateTimeOffset()}
            };

            notes.ForEach(n => context.Notes.Add(n));
            context.SaveChanges();
        }
    }
}
