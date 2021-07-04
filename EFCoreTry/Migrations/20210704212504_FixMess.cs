using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTry.Migrations
{
    public partial class FixMess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Customer_OwnerId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Appoinment_Categories_CustomerId",
                table: "Appoinment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appoinment_Characters_VetId",
                table: "Appoinment");

            migrationBuilder.DropForeignKey(
                name: "FK_Breed_Animals_AnimalId",
                table: "Breed");

            migrationBuilder.DropForeignKey(
                name: "FK_Breed_Category_CategoryId",
                table: "Breed");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Customer_CustomerId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Employee_EmployeeId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Products_ProductId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Supplier_SupplierId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Products_ProductId",
                table: "Tag");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Products_TempId",
                table: "Products");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Customer_TempId1",
                table: "Customer");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Customer_TempId2",
                table: "Customer");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Category_TempId",
                table: "Category");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Category_TempId1",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animals",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_OwnerId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WorldwideBoxOfficeGross",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PetName",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TempId1",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "TempId1",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "Animals",
                newName: "Animal");

            migrationBuilder.RenameColumn(
                name: "DurationInMinutes",
                table: "Products",
                newName: "Stocks");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "CityId");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "CertID");

            migrationBuilder.RenameColumn(
                name: "TempId2",
                table: "Customer",
                newName: "Birthday");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Customer",
                newName: "CityId");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customer",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_ProductId",
                table: "Customer",
                newName: "IX_Customer_CityId");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Animal",
                newName: "DateBorn");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "Tag",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Tag",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Category",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Category",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Category",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Category",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Breed",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AnimalId",
                table: "Breed",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Breed",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Breed",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Appoinment",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "City",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "City",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<string>(
                name: "AreaCode",
                table: "City",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Animal",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Animal",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Animal",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Animal",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breed",
                table: "Breed",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animal",
                table: "Animal",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerId = table.Column<Guid>(type: "TEXT", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInfo_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactInfo_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CityId",
                table: "Employees",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ProductId",
                table: "Category",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Breed_AnimalId",
                table: "Breed",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Breed_CategoryId",
                table: "Breed",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_CustomerId",
                table: "Animal",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_CustomerId",
                table: "ContactInfo",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_EmployeeId",
                table: "ContactInfo",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Customer_CustomerId",
                table: "Animal",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appoinment_Customer_CustomerId",
                table: "Appoinment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appoinment_Employees_VetId",
                table: "Appoinment",
                column: "VetId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breed_Animal_AnimalId",
                table: "Breed",
                column: "AnimalId",
                principalTable: "Animal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breed_Category_CategoryId",
                table: "Breed",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Products_ProductId",
                table: "Category",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_City_CityId",
                table: "Customer",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_City_CityId",
                table: "Employees",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Products_ProductId",
                table: "Tag",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Customer_CustomerId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appoinment_Customer_CustomerId",
                table: "Appoinment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appoinment_Employees_VetId",
                table: "Appoinment");

            migrationBuilder.DropForeignKey(
                name: "FK_Breed_Animal_AnimalId",
                table: "Breed");

            migrationBuilder.DropForeignKey(
                name: "FK_Breed_Category_CategoryId",
                table: "Breed");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Products_ProductId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_City_CityId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_City_CityId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Products_ProductId",
                table: "Tag");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CityId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ProductId",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breed",
                table: "Breed");

            migrationBuilder.DropIndex(
                name: "IX_Breed_AnimalId",
                table: "Breed");

            migrationBuilder.DropIndex(
                name: "IX_Breed_CategoryId",
                table: "Breed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animal",
                table: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Animal_CustomerId",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Breed");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Breed");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Animal");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "Animal",
                newName: "Animals");

            migrationBuilder.RenameColumn(
                name: "Stocks",
                table: "Products",
                newName: "DurationInMinutes");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CertID",
                table: "Employees",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Customer",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Customer",
                newName: "TempId2");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customer",
                newName: "Phone");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_CityId",
                table: "Customer",
                newName: "IX_Customer_ProductId");

            migrationBuilder.RenameColumn(
                name: "DateBorn",
                table: "Animals",
                newName: "OwnerId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Tag",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tag",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "TempId",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "WorldwideBoxOfficeGross",
                table: "Products",
                type: "REAL",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Customer",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customer",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Customer",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Customer",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customer",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PetName",
                table: "Customer",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Customer",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TempId1",
                table: "Customer",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "TempId",
                table: "Category",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempId1",
                table: "Category",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Breed",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Breed",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Appoinment",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Cities",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Cities",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "AreaCode",
                table: "Cities",
                type: "INTEGER",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Animals",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Products_TempId",
                table: "Products",
                column: "TempId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Customer_TempId1",
                table: "Customer",
                column: "TempId1");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Customer_TempId2",
                table: "Customer",
                column: "TempId2");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Category_TempId",
                table: "Category",
                column: "TempId");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Category_TempId1",
                table: "Category",
                column: "TempId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animals",
                table: "Animals",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Birthplace = table.Column<string>(type: "TEXT", nullable: true),
                    TempId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.UniqueConstraint("AK_Categories_TempId", x => x.TempId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Birthplace = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PID = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TempId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.UniqueConstraint("AK_Characters_TempId", x => x.TempId);
                    table.ForeignKey(
                        name: "FK_Characters_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    TempId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_Employee_TempId", x => x.TempId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    TempId1 = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_Product_TempId1", x => x.TempId1);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    TempId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_Supplier_TempId", x => x.TempId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Category_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Category",
                        principalColumn: "TempId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "TempId1",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_OwnerId",
                table: "Animals",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ProductId",
                table: "Characters",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Customer_OwnerId",
                table: "Animals",
                column: "OwnerId",
                principalTable: "Customer",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appoinment_Categories_CustomerId",
                table: "Appoinment",
                column: "CustomerId",
                principalTable: "Categories",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appoinment_Characters_VetId",
                table: "Appoinment",
                column: "VetId",
                principalTable: "Characters",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breed_Animals_AnimalId",
                table: "Breed",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breed_Category_CategoryId",
                table: "Breed",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Customer_CustomerId",
                table: "Customer",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "TempId2",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Employee_EmployeeId",
                table: "Customer",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Products_ProductId",
                table: "Customer",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Supplier_SupplierId",
                table: "Customer",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Products_ProductId",
                table: "Tag",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
