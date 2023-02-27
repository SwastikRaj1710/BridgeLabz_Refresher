using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeDBProgram // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "data source=SWASTIK-ENG;initial catalog=EmployeeDB;integrated security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Insert a row in the Employee table");
                Console.WriteLine("2. Update a row in the Employee table");
                Console.WriteLine("3. Delete a row in the Employee table");
                Console.WriteLine("4. Displays rows in the Employee table");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the emp_id, emp_name, job_name, manager_id, hire_date, salary and dep_id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        string name = Console.ReadLine();
                        string job_name = Console.ReadLine();
                        int manager_id = Convert.ToInt32(Console.ReadLine());
                        string hire_date = Console.ReadLine();
                        double salary = Convert.ToDouble(Console.ReadLine());
                        int dep_id = Convert.ToInt32(Console.ReadLine());

                        SqlCommand cmd = new SqlCommand("spInsertToEmployee", conn);
                        try
                        {
                            conn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", id));
                            cmd.Parameters.Add(new SqlParameter("@name", name));
                            cmd.Parameters.Add(new SqlParameter("@job_name", job_name));
                            cmd.Parameters.Add(new SqlParameter("@manager_id", manager_id));
                            cmd.Parameters.Add(new SqlParameter("@hire_date", hire_date));
                            cmd.Parameters.Add(new SqlParameter("@salary", salary));
                            cmd.Parameters.Add(new SqlParameter("@dep_id", dep_id));
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Inserted");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the Emp_id whose details you want to update");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the updated emp_name, job_name, manager_id, hire_date, salary and dep_id");
                        name = Console.ReadLine();
                        job_name = Console.ReadLine();
                        manager_id = Convert.ToInt32(Console.ReadLine());
                        hire_date = Console.ReadLine();
                        salary = Convert.ToDouble(Console.ReadLine());
                        dep_id = Convert.ToInt32(Console.ReadLine());

                        cmd = new SqlCommand("spUpdateToEmployee", conn);
                        try
                        {
                            conn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", id));
                            cmd.Parameters.Add(new SqlParameter("@name", name));
                            cmd.Parameters.Add(new SqlParameter("@job_name", job_name));
                            cmd.Parameters.Add(new SqlParameter("@manager_id", manager_id));
                            cmd.Parameters.Add(new SqlParameter("@hire_date", hire_date));
                            cmd.Parameters.Add(new SqlParameter("@salary", salary));
                            cmd.Parameters.Add(new SqlParameter("@dep_id", dep_id));
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Updated");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter the Emp_id whose details you want to delete");
                        id = Convert.ToInt32(Console.ReadLine());
                        cmd = new SqlCommand("spDeleteFromEmployee", conn);
                        try
                        {
                            conn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@id", id));
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Deleted");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();
                        }
                        break;
                    case 4:
                        cmd = new SqlCommand("spDisplayFromEmployee", conn);
                        try
                        {
                            conn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlDataAdapter ad = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            ad.Fill(dataTable);

                            foreach(DataRow row in dataTable.Rows) 
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}