﻿// <auto-generated />
using System;
using FaceBookApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FaceBookApplication.Persistence.Migrations
{
    [DbContext(typeof(FacebookContext))]
    partial class FacebookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Bloked", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LikeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LikeId");

                    b.ToTable("Blokeds");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Delete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FriendId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FriendId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LikeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LikeId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Bloked", b =>
                {
                    b.HasOne("FaceBookApplication.Domain.Entity.Like", "Like")
                        .WithMany("Blokeds")
                        .HasForeignKey("LikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Like");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Comment", b =>
                {
                    b.HasOne("FaceBookApplication.Domain.Entity.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Friend", b =>
                {
                    b.HasOne("FaceBookApplication.Domain.Entity.User", "User")
                        .WithMany("Friends")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Like", b =>
                {
                    b.HasOne("FaceBookApplication.Domain.Entity.Comment", "Comment")
                        .WithMany("Likes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Post", b =>
                {
                    b.HasOne("FaceBookApplication.Domain.Entity.Friend", "Friends")
                        .WithMany("Posts")
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FaceBookApplication.Domain.Entity.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Friends");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Request", b =>
                {
                    b.HasOne("FaceBookApplication.Domain.Entity.Like", "Like")
                        .WithMany()
                        .HasForeignKey("LikeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Like");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Comment", b =>
                {
                    b.Navigation("Likes");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Friend", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Like", b =>
                {
                    b.Navigation("Blokeds");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("FaceBookApplication.Domain.Entity.User", b =>
                {
                    b.Navigation("Friends");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
