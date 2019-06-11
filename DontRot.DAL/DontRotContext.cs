using System;
using DontRot.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DontRot.DAL
{
    public class DontRotContext : DbContext
    {
        public DontRotContext(DbContextOptions<DontRotContext> options)
            : base(options){}


        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Storage> Storages { get; set; }
		public DbSet<Slot> Slots { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Tej" });
			modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Felvágott" });
			modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Konzerv" });
			modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Banán" });

			modelBuilder.Entity<Storage>().HasData(new Storage { Id = 1, Name = "Hűtő" });
			modelBuilder.Entity<Storage>().HasData(new Storage { Id = 2, Name = "Konyhaszekrény" });

			modelBuilder.Entity<Slot>().HasData(new Slot { Id = 1, Name = "Felső polc", StorageId = 1 });
			modelBuilder.Entity<Slot>().HasData(new Slot { Id = 2, Name = "Alsó polc", StorageId = 1 });
			modelBuilder.Entity<Slot>().HasData(new Slot { Id = 3, Name = "Bal fiók", StorageId = 2 });
			modelBuilder.Entity<Slot>().HasData(new Slot { Id = 4, Name = "Jobb fiók", StorageId = 2 });

			modelBuilder.Entity<Food>().HasData(new Food {
				Id = 1,
				Name = "Mizo dobozos tej",
				SlotId = 2,
				CategoryId = 1,
				Quantity = 1,
				ExpiryDateTime = DateTime.Now + new TimeSpan(5,0,0,0)
			});

			modelBuilder.Entity<Food>().HasData(new Food
			{
				Id = 2,
				Name = "Alföldi zacskós tej",
				SlotId = 2,
				CategoryId = 1,
				Quantity = 1,
				ExpiryDateTime = DateTime.Now + new TimeSpan(3, 0, 0, 0)
			});

			modelBuilder.Entity<Food>().HasData(new Food
			{
				Id = 3,
				Name = "Pick szeletelt téliszalámi",
				SlotId = 1,
				CategoryId = 2,
				Quantity = 5,
				ExpiryDateTime = DateTime.Now + new TimeSpan(11, 0, 0, 0)
			});

			modelBuilder.Entity<Food>().HasData(new Food
			{
				Id = 4,
				Name = "CBA páros kolbász",
				SlotId = 1,
				CategoryId = 2,
				Quantity = 1,
				ExpiryDateTime = DateTime.Now + new TimeSpan(72, 0, 0, 0)
			});


			modelBuilder.Entity<Food>().HasData(new Food
			{
				Id = 5,
				Name = "Spanyol banán",
				SlotId = 3,
				CategoryId = 4,
				Quantity = 3,
				ExpiryDateTime = DateTime.Now + new TimeSpan(4, 0, 0, 0)
			});

			modelBuilder.Entity<Food>().HasData(new Food
			{
				Id = 6,
				Name = "Bab konzerv",
				SlotId = 4,
				CategoryId = 3,
				Quantity = 2,
				ExpiryDateTime = DateTime.Now + new TimeSpan(666, 0, 0, 0)
			});

			modelBuilder.Entity<Storage>()
                .HasMany(o => o.Slots)
                .WithOne(po => po.Storage)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Food>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();
        }

    }
}
