using System;
using Microsoft.Data.SqlClient;

namespace CRUDproducts
{
    internal class Program
    {
        private static readonly string connectionString = "Data Source=LONGTAIL-ACER\\SQLEXPRESS;Initial Catalog=AppleStoreDb;Integrated Security=True;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Insert Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Insert();
                        break;
                    case "2":
                        Display();
                        break;
                    case "3":
                        Update();
                        break;
                    case "4":
                        Delete();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void Insert()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Description: ");
                    string description = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    float price = float.Parse(Console.ReadLine());

                    string query = "INSERT INTO Products (Name, Description, Price) VALUES (@Name, @Description, @Price)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Price", price);

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Product added successfully.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void Display()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Products";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("\n--- Product List ---");
                            Console.WriteLine($"{"ID",-5} {"Name",-20} {"Description",-30} {"Price",-10}");

                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader.GetInt32(0),-5} {reader.GetString(1),-20} {reader.GetString(2),-30} {reader.GetDouble(3),-10:C}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void Update()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    Console.Write("Enter Product ID to update: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter new Product Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter new Description: ");
                    string description = Console.ReadLine();

                    Console.Write("Enter new Price: ");
                    float price = float.Parse(Console.ReadLine());

                    string query = "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Price", price);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Product updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No product found with the given ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void Delete()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    Console.Write("Enter Product ID to delete: ");
                    int id = int.Parse(Console.ReadLine());

                    string query = "DELETE FROM Products WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Product deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No product found with the given ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
