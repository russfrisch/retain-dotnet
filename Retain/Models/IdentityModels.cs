using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Retain.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string EmailAddress { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public override int SaveChanges()
        {
            try
            {
                DateTime time = DateTime.Now;
                foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Added))
                {
                    if (entry.Property("Created").CurrentValue == null)
                        entry.Property("Created").CurrentValue = time;
                    if (entry.Property("Updated").CurrentValue == null)
                        entry.Property("Updated").CurrentValue = time;
                }
                foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified))
                {
                    if (entry.Property("Updated").CurrentValue == null)
                        entry.Property("Updated").CurrentValue = time;
                }
            }
            catch (Exception)
            {
                Console.Out.WriteLine("This entity does not have Created/Updated fields.");
            }

            return base.SaveChanges();
        }

        public System.Data.Entity.DbSet<Retain.Models.Note> Notes { get; set; }
    }
}