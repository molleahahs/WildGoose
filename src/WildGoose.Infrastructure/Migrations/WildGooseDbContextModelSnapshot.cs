﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WildGoose.Infrastructure;

#nullable disable

namespace WildGoose.Infrastructure.Migrations
{
    [DbContext(typeof(WildGooseDbContext))]
    partial class WildGooseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("claim_value");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("character varying(36)")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("wild_goose_role_claim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("claim_value");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character varying(36)")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("wild_goose_user_claim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("provider_key");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text")
                        .HasColumnName("provider_display_name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character varying(36)")
                        .HasColumnName("user_id");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("wild_goose_user_login", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("character varying(36)")
                        .HasColumnName("user_id");

                    b.Property<string>("RoleId")
                        .HasColumnType("character varying(36)")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("wild_goose_user_role", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("character varying(36)")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("wild_goose_user_token", (string)null);
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.Organization", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("address");

                    b.Property<string>("Code")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("code");

                    b.Property<long?>("CreationTime")
                        .HasColumnType("bigint")
                        .HasColumnName("creation_time");

                    b.Property<string>("CreatorId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("creator_id");

                    b.Property<string>("CreatorName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("creator_name");

                    b.Property<string>("DeleterId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("deleter_id");

                    b.Property<string>("DeleterName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("deleter_name");

                    b.Property<long?>("DeletionTime")
                        .HasColumnType("bigint")
                        .HasColumnName("deletion_time");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<long?>("LastModificationTime")
                        .HasColumnType("bigint")
                        .HasColumnName("last_modification_time");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("last_modifier_id");

                    b.Property<string>("LastModifierName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("last_modifier_name");

                    b.Property<string>("Metadata")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("metadata");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("ParentId")
                        .HasColumnType("character varying(36)")
                        .HasColumnName("parent_id");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("wild_goose_organization", (string)null);
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.OrganizationAdministrator", b =>
                {
                    b.Property<string>("OrganizationId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("organization_id");

                    b.Property<string>("UserId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("user_id");

                    b.HasKey("OrganizationId", "UserId");

                    b.ToTable("wild_goose_organization_administrator", (string)null);
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.OrganizationScope", b =>
                {
                    b.Property<string>("OrganizationId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("organization_id");

                    b.Property<string>("Scope")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("scope");

                    b.HasKey("OrganizationId", "Scope");

                    b.ToTable("wild_goose_organization_scope", (string)null);
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.OrganizationUser", b =>
                {
                    b.Property<string>("OrganizationId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("organization_id");

                    b.Property<string>("UserId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("user_id");

                    b.HasKey("OrganizationId", "UserId");

                    b.ToTable("wild_goose_organization_user", (string)null);
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text")
                        .HasColumnName("concurrency_stamp");

                    b.Property<long?>("CreationTime")
                        .HasColumnType("bigint")
                        .HasColumnName("creation_time");

                    b.Property<string>("CreatorId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("creator_id");

                    b.Property<string>("CreatorName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("creator_name");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("description");

                    b.Property<long?>("LastModificationTime")
                        .HasColumnType("bigint")
                        .HasColumnName("last_modification_time");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("last_modifier_id");

                    b.Property<string>("LastModifierName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("last_modifier_name");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_name");

                    b.Property<string>("Statement")
                        .HasMaxLength(6000)
                        .HasColumnType("character varying(6000)")
                        .HasColumnName("statement");

                    b.Property<int>("Version")
                        .HasColumnType("integer")
                        .HasColumnName("version");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("wild_goose_role", (string)null);
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.RoleAssignableRole", b =>
                {
                    b.Property<string>("RoleId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("role_id");

                    b.Property<string>("AssignableId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("assignable_id");

                    b.HasKey("RoleId", "AssignableId");

                    b.ToTable("wild_goose_role_assignable_role", (string)null);
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("Address")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("address");

                    b.Property<string>("Code")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("code");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text")
                        .HasColumnName("concurrency_stamp");

                    b.Property<long?>("CreationTime")
                        .HasColumnType("bigint")
                        .HasColumnName("creation_time");

                    b.Property<string>("CreatorId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("creator_id");

                    b.Property<string>("CreatorName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("creator_name");

                    b.Property<string>("DeleterId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("deleter_id");

                    b.Property<string>("DeleterName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("deleter_name");

                    b.Property<long?>("DeletionTime")
                        .HasColumnType("bigint")
                        .HasColumnName("deletion_time");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("email_confirmed");

                    b.Property<string>("FamilyName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("family_name");

                    b.Property<string>("GivenName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("given_name");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<long?>("LastModificationTime")
                        .HasColumnType("bigint")
                        .HasColumnName("last_modification_time");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("last_modifier_id");

                    b.Property<string>("LastModifierName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("last_modifier_name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lockout_end");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("middle_name");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("NickName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("nick_name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("Picture")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("picture");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text")
                        .HasColumnName("security_stamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("wild_goose_user", (string)null);
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.UserExtension", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)")
                        .HasColumnName("id");

                    b.Property<long?>("DepartureTime")
                        .HasColumnType("bigint")
                        .HasColumnName("departure_time");

                    b.Property<bool>("HiddenSensitiveData")
                        .HasColumnType("boolean")
                        .HasColumnName("hidden_sensitive_data");

                    b.Property<bool>("PasswordContainsDigit")
                        .HasColumnType("boolean")
                        .HasColumnName("password_contains_digit");

                    b.Property<bool>("PasswordContainsLowercase")
                        .HasColumnType("boolean")
                        .HasColumnName("password_contains_lowercase");

                    b.Property<bool>("PasswordContainsNonAlphanumeric")
                        .HasColumnType("boolean")
                        .HasColumnName("password_contains_non_alphanumeric");

                    b.Property<bool>("PasswordContainsUppercase")
                        .HasColumnType("boolean")
                        .HasColumnName("password_contains_uppercase");

                    b.Property<int>("PasswordLength")
                        .HasColumnType("integer")
                        .HasColumnName("password_length");

                    b.Property<bool>("ResetPasswordFlag")
                        .HasColumnType("boolean")
                        .HasColumnName("reset_password_flag");

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("wild_goose_user_extension", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("WildGoose.Domain.Entity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WildGoose.Domain.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WildGoose.Domain.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("WildGoose.Domain.Entity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildGoose.Domain.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WildGoose.Domain.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WildGoose.Domain.Entity.Organization", b =>
                {
                    b.HasOne("WildGoose.Domain.Entity.Organization", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });
#pragma warning restore 612, 618
        }
    }
}
