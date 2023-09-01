using DataAccessExample;
namespace Program
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Abstraction C#
      Database db;

      db = new SQLServerDatabase();

      db.OpenConnection();
      db.CloseConnection();
      db.ExecuteQuery("SELECT ALL");
    }
  }
}