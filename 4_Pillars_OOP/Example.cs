using System;
//Example: Data Access Layer with Abstraction

namespace DataAccessExample
{
    //Abstraction: The Database abstract class serves as a blueprint for database operations. It does not provide implementations but defines the structure that all derived classes should follow.
    //The abstract class encapsulates the common functionalities (opening a connection, closing a connection, and executing a query) that any type of database should have.
    public abstract class Database
    {
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract void ExecuteQuery(string query);
    }
    //Inheritance: The SqlServerDatabase and MongoDatabase classes inherit from the Database abstract class and provide specific implementations.
    public class SQLServerDatabase : Database
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL Server database connection...");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL Server database connection...");
        }
        public override void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing SQL query: {query}");
        }
    }
    //Polymorphism: The Database reference db in the Main method is polymorphic, as it can take on multiple forms (SqlServerDatabase or MongoDatabase). This allows us to switch database types easily, enhancing flexibility and maintainability.
    public class MongoDatabase : Database
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Opening MongoDB database connection...");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing MongoDB database connection...");
        }

        public override void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing MongoDB query: {query}");
        }
    }
}