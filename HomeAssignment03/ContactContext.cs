using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment03
{
	public class ContactContext : DbContext
	{
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<PhoneNumber> PhoneNumbers { get; set; }
		public DbSet<AddressType> AddressTypes { get; set; }
		public DbSet<PhoneType> PhoneTypes { get; set; }

		/*
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Contact>().HasMany(s => s.Addresses).WithRequired().WillCascadeOnDelete(true);
			modelBuilder.Entity<Contact>().HasMany(s => s.PhoneNumbers).WithRequired().WillCascadeOnDelete(true);

			modelBuilder.Entity<Contact>().HasKey(s => s.ContactId).Property(s => s.ContactId).IsRequired();
			modelBuilder.Entity<Address>().HasKey(s => s.AddressId).Property(s => s.AddressId).IsRequired();
			modelBuilder.Entity<AddressType>().HasKey(s => s.AddressTypeId).Property(s => s.AddressTypeId).IsRequired();
			modelBuilder.Entity<PhoneNumber>().HasKey(s => s.PhoneNumberId).Property(s => s.PhoneNumberId).IsRequired();
			modelBuilder.Entity<PhoneType>().HasKey(s => s.PhoneTypeId).Property(s => s.PhoneTypeId).IsRequired();
		}*/
	}
}