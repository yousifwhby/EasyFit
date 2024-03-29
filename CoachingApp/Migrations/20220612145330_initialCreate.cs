﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoachingApp.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    lastName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    firstName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    mobileNum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    gender = table.Column<bool>(type: "bit", nullable: true),
                    city = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    height = table.Column<double>(type: "float", nullable: true),
                    weight = table.Column<double>(type: "float", nullable: true),
                    image = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                    table.ForeignKey(
                        name: "FK_Client_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    mobileNum = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    gender = table.Column<bool>(type: "bit", nullable: true),
                    city = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    country = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yearsExperience = table.Column<int>(type: "int", nullable: true),
                    rating = table.Column<double>(type: "float", nullable: true),
                    NumberOfRating = table.Column<int>(type: "int", nullable: true),
                    image = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    speciality = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.id);
                    table.ForeignKey(
                        name: "FK_Coach_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Coach_Speciality",
                        column: x => x.speciality,
                        principalTable: "Speciality",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    coachID = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificates", x => new { x.name, x.coachID });
                    table.ForeignKey(
                        name: "FK_certificates_coach",
                        column: x => x.coachID,
                        principalTable: "Coach",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Excercise",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    link = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    coachID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excercise", x => x.id);
                    table.ForeignKey(
                        name: "FK_Excercise_coach",
                        column: x => x.coachID,
                        principalTable: "Coach",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    coachID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.id);
                    table.ForeignKey(
                        name: "FK_meal_coach",
                        column: x => x.coachID,
                        principalTable: "Coach",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Nutrition_Subscription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    duration = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    coachID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition_Subscription", x => x.id);
                    table.ForeignKey(
                        name: "FK_nutrition_subscription_coach",
                        column: x => x.coachID,
                        principalTable: "Coach",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    notes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    duration = table.Column<int>(type: "int", nullable: true),
                    coachID = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.id);
                    table.ForeignKey(
                        name: "FK_Workout_coach",
                        column: x => x.coachID,
                        principalTable: "Coach",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Workout_Subscription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    coachID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout_Subscription", x => x.id);
                    table.ForeignKey(
                        name: "FK_Workout_Subscription_coach",
                        column: x => x.coachID,
                        principalTable: "Coach",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "WorkoutSets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    coachID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutSets", x => x.id);
                    table.ForeignKey(
                        name: "FK_Workout_Sets_coach",
                        column: x => x.coachID,
                        principalTable: "Coach",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Client_Meal_NSub",
                columns: table => new
                {
                    clientID = table.Column<int>(type: "int", nullable: false),
                    mealID = table.Column<int>(type: "int", nullable: false),
                    subID = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_meal_sub", x => new { x.clientID, x.mealID, x.subID, x.date });
                    table.ForeignKey(
                        name: "FK_client_meal_sub_client",
                        column: x => x.clientID,
                        principalTable: "Client",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_client_meal_sub_meal",
                        column: x => x.mealID,
                        principalTable: "Meal",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_client_meal_sub_nutrition_subscription",
                        column: x => x.subID,
                        principalTable: "Nutrition_Subscription",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Client_NSub",
                columns: table => new
                {
                    clientID = table.Column<int>(type: "int", nullable: false),
                    subID = table.Column<int>(type: "int", nullable: false),
                    startDate = table.Column<DateTime>(type: "date", nullable: false),
                    coachID = table.Column<int>(type: "int", nullable: false),
                    accept = table.Column<bool>(type: "bit", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    comment = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_coach_Nsubscription_1", x => new { x.clientID, x.subID, x.startDate });
                    table.ForeignKey(
                        name: "FK_Client_coach_Nsubscription_client",
                        column: x => x.clientID,
                        principalTable: "Client",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Client_coach_Nsubscription_nutrition_subscription",
                        column: x => x.subID,
                        principalTable: "Nutrition_Subscription",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Workout_Exercise",
                columns: table => new
                {
                    workoutID = table.Column<int>(type: "int", nullable: false),
                    excerciseID = table.Column<int>(type: "int", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false),
                    sets = table.Column<int>(type: "int", nullable: true),
                    reps = table.Column<int>(type: "int", nullable: true),
                    notes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workout_excercise", x => new { x.workoutID, x.excerciseID, x.rank });
                    table.ForeignKey(
                        name: "FK_workout_excercise_Excercise",
                        column: x => x.excerciseID,
                        principalTable: "Excercise",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_workout_excercise_Workout",
                        column: x => x.workoutID,
                        principalTable: "Workout",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Client_Workout_WSub",
                columns: table => new
                {
                    clientID = table.Column<int>(type: "int", nullable: false),
                    workoutID = table.Column<int>(type: "int", nullable: false),
                    subID = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: true),
                    clientNotes = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client_workout_sub", x => new { x.clientID, x.workoutID, x.subID, x.date });
                    table.ForeignKey(
                        name: "FK_client_workout_sub_client",
                        column: x => x.clientID,
                        principalTable: "Client",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_client_workout_sub_Workout",
                        column: x => x.workoutID,
                        principalTable: "Workout",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_client_workout_sub_Workout_Subscription",
                        column: x => x.subID,
                        principalTable: "Workout_Subscription",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Client_WSub",
                columns: table => new
                {
                    clientID = table.Column<int>(type: "int", nullable: false),
                    subID = table.Column<int>(type: "int", nullable: false),
                    startDate = table.Column<DateTime>(type: "date", nullable: false),
                    coachID = table.Column<int>(type: "int", nullable: false),
                    accept = table.Column<bool>(type: "bit", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    comment = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_coach_WOsubscription_1", x => new { x.clientID, x.subID, x.startDate });
                    table.ForeignKey(
                        name: "FK_Client_coach_WOsubscription_client",
                        column: x => x.clientID,
                        principalTable: "Client",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Client_coach_WOsubscription_Workout_Subscription",
                        column: x => x.subID,
                        principalTable: "Workout_Subscription",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Workout_WorkoutSets",
                columns: table => new
                {
                    workout_set_id = table.Column<int>(type: "int", nullable: false),
                    workoutID = table.Column<int>(type: "int", nullable: false),
                    rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workouts_in_sets_1", x => new { x.workout_set_id, x.workoutID });
                    table.ForeignKey(
                        name: "FK_workouts_in_sets_Workout",
                        column: x => x.workoutID,
                        principalTable: "Workout",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_workouts_in_sets_Workout_Sets",
                        column: x => x.workout_set_id,
                        principalTable: "WorkoutSets",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_coachID",
                table: "Certificates",
                column: "coachID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_UserId",
                table: "Client",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_Meal_NSub_mealID",
                table: "Client_Meal_NSub",
                column: "mealID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Meal_NSub_subID",
                table: "Client_Meal_NSub",
                column: "subID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_NSub_subID",
                table: "Client_NSub",
                column: "subID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Workout_WSub_subID",
                table: "Client_Workout_WSub",
                column: "subID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Workout_WSub_workoutID",
                table: "Client_Workout_WSub",
                column: "workoutID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_WSub_subID",
                table: "Client_WSub",
                column: "subID");

            migrationBuilder.CreateIndex(
                name: "IX_Coach_speciality",
                table: "Coach",
                column: "speciality");

            migrationBuilder.CreateIndex(
                name: "IX_Coach_UserId",
                table: "Coach",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Excercise_coachID",
                table: "Excercise",
                column: "coachID");

            migrationBuilder.CreateIndex(
                name: "IX_Meal_coachID",
                table: "Meal",
                column: "coachID");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_Subscription_coachID",
                table: "Nutrition_Subscription",
                column: "coachID");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_coachID",
                table: "Workout",
                column: "coachID");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Exercise_excerciseID",
                table: "Workout_Exercise",
                column: "excerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_Subscription_coachID",
                table: "Workout_Subscription",
                column: "coachID");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_WorkoutSets_workoutID",
                table: "Workout_WorkoutSets",
                column: "workoutID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutSets_coachID",
                table: "WorkoutSets",
                column: "coachID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "Client_Meal_NSub");

            migrationBuilder.DropTable(
                name: "Client_NSub");

            migrationBuilder.DropTable(
                name: "Client_Workout_WSub");

            migrationBuilder.DropTable(
                name: "Client_WSub");

            migrationBuilder.DropTable(
                name: "Workout_Exercise");

            migrationBuilder.DropTable(
                name: "Workout_WorkoutSets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "Nutrition_Subscription");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Workout_Subscription");

            migrationBuilder.DropTable(
                name: "Excercise");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "WorkoutSets");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Speciality");
        }
    }
}
