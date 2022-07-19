﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using garden_planner.Data;

#nullable disable

namespace garden_planner.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("garden_planner.Data.Crop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Crops");
                });

            modelBuilder.Entity("garden_planner.Data.PlantVariety", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Autum")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lifecycle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Spring")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Summer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sun")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Water")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Winter")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("PlantVarieties");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Autum = false,
                            Description = "This is an aromatic herb which has many culinary uses, particularly popular in Mediterranean dishes.",
                            Image = "basil.svg",
                            Lifecycle = "Annual",
                            Name = "Basil",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 2,
                            Autum = true,
                            Description = "Peas are best planted in Autumn & Winter, whilst most Beans are best planted in Spring & Summer. As part of the legume plant family, pea and bean plants.",
                            Image = "peas.svg",
                            Lifecycle = "Annual",
                            Name = "Peas",
                            Spring = true,
                            Summer = false,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = true
                        },
                        new
                        {
                            ID = 3,
                            Autum = true,
                            Description = "A splendid maincrop carrot, producing long, pointed roots. Its fine colouring and excellent flavour make this one of the most appetising of carrots.",
                            Image = "carrot.svg",
                            Lifecycle = "Annual",
                            Name = "Carrot",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = true
                        },
                        new
                        {
                            ID = 4,
                            Autum = false,
                            Description = "These tomatos are a favourite, with meaty flesh and very few seeds. Its excellent flavour makes it perfect for cooking or even eaten raw.",
                            Image = "tomato.svg",
                            Lifecycle = "Annual",
                            Name = "Tomato",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 5,
                            Autum = false,
                            Description = "These peppers (chillies) are so useful in pickles, sauces and curries. Chilli vinegar can be made from the green fruits.",
                            Image = "chili.svg",
                            Lifecycle = "Annual",
                            Name = "Chili",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 6,
                            Autum = true,
                            Description = "Very versatile herbs for rich meat dishes, especially lamb. Excellent in stuffings and an important flavouring in many Mediterranean dishes.",
                            Image = "rosemerry.svg",
                            Lifecycle = "Perennial",
                            Name = "Rosemerry",
                            Spring = true,
                            Summer = true,
                            Sun = "Partial",
                            Water = "Moderate",
                            Winter = true
                        },
                        new
                        {
                            ID = 7,
                            Autum = true,
                            Description = "A mild flavour and tasty addition to salads. Prefers an open sunny position. Young tender tops can be used like chives.",
                            Image = "spring-onion.svg",
                            Lifecycle = "Perennial",
                            Name = "Spring Onion",
                            Spring = true,
                            Summer = true,
                            Sun = "Partial",
                            Water = "Moderate",
                            Winter = true
                        },
                        new
                        {
                            ID = 8,
                            Autum = false,
                            Description = "Bring a taste of the Mediterranean to your life! The attractive green and red fruits will add colour to your garden, spice to your salads and variety to your cooking. ",
                            Image = "capsicum.svg",
                            Lifecycle = "Annual",
                            Name = "Capsicum",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 9,
                            Autum = true,
                            Description = "In Greek cooking, mint is used in everything from cheese dishes to tomato-based sauces, meats, and rice dishes. ",
                            Image = "mint.svg",
                            Lifecycle = "Perennial",
                            Name = "Mint",
                            Spring = true,
                            Summer = true,
                            Sun = "Partial",
                            Water = "Moderate",
                            Winter = true
                        },
                        new
                        {
                            ID = 10,
                            Autum = true,
                            Description = "The most widely grown lettuce. It has a tightly packed, crisp and very crunchy heart with sweet and delicious leaves. Easy to grow, hardy and reliable.",
                            Image = "lettuce.svg",
                            Lifecycle = "Annual",
                            Name = "Lettuce",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 11,
                            Autum = true,
                            Description = "Our choice as the best all-round early onion, Hunter River Brown produces a large, globe-shaped onion with a light brown skin.",
                            Image = "onion.svg",
                            Lifecycle = "Annual",
                            Name = "Onion",
                            Spring = false,
                            Summer = false,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 12,
                            Autum = true,
                            Description = "Popular, well-established variety producing high yields of large tasty sprouts. Medium height, well suited to the home garden.",
                            Image = "brussels-sprouts.svg",
                            Lifecycle = "Annual",
                            Name = "Brussels Sprouts",
                            Spring = false,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 13,
                            Autum = true,
                            Description = "Garlic is very easy to grow. Fresh Garlic from your garden is quite snappy, has a much stronger flavour.",
                            Image = "garlic.svg",
                            Lifecycle = "Annual",
                            Name = "Garlic",
                            Spring = false,
                            Summer = false,
                            Sun = "Full",
                            Water = "Low",
                            Winter = true
                        },
                        new
                        {
                            ID = 14,
                            Autum = false,
                            Description = "An excellent, sweet tasting, burpless variety. The fruits can be eaten whole or sliced but are best when picked up to 10cm (4in) long. ",
                            Image = "cucumber.svg",
                            Lifecycle = "Annual",
                            Name = "Cucumber",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Low",
                            Winter = false
                        },
                        new
                        {
                            ID = 15,
                            Autum = false,
                            Description = "Sweet and tasty cherry sized fruits. A high yielding heirloom variety. Seed produced by Organic methods. Excellent source of vitamin C and antioxidants.",
                            Image = "cherry-tomato.svg",
                            Lifecycle = "Annual",
                            Name = "Cherry tomato",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 16,
                            Autum = true,
                            Description = "One of our favourites and rapidly gaining in popularity, this delightful vegetable bridges the gap between Summer and Winter vegetables.",
                            Image = "broccoli.svg",
                            Lifecycle = "Annual",
                            Name = "Broccoli",
                            Spring = false,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 17,
                            Autum = true,
                            Description = "Provides a continuous harvest over a long period, has a mild delicate flavourideal for sandwiches or steaming.",
                            Image = "spinach.svg",
                            Lifecycle = "Perennial",
                            Name = "Spinach",
                            Spring = true,
                            Summer = true,
                            Sun = "Full",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 18,
                            Autum = true,
                            Description = "Slow bolting heirloom variety, Medium-sized round solid heads with few outer leaves. ",
                            Image = "cabbage.svg",
                            Lifecycle = "Annual",
                            Name = "Cabbage",
                            Spring = false,
                            Summer = true,
                            Sun = "Partial",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 19,
                            Autum = true,
                            Description = "An extremely useful cauliflower variety that produces large pure white heads with a first class flavour.",
                            Image = "cauliflower.svg",
                            Lifecycle = "Annual",
                            Name = "Cauliflower",
                            Spring = false,
                            Summer = true,
                            Sun = "Partial",
                            Water = "Moderate",
                            Winter = false
                        },
                        new
                        {
                            ID = 20,
                            Autum = false,
                            Description = "Jarrahdale is of excellent quality with a sweet flavour. Cuts well. Best results are obtained in full sun on rich, well drained soil.",
                            Image = "pumpkin.svg",
                            Lifecycle = "Annual",
                            Name = "Pumpkin",
                            Spring = true,
                            Summer = true,
                            Sun = "Partial",
                            Water = "Moderate",
                            Winter = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
