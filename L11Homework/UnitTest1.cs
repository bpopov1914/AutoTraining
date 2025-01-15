using Npgsql;

namespace L11Homework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Database.Database databaseConnection = new Database.Database();
        using (var connection = new NpgsqlConnection(databaseConnection.connectionString))
        {
            connection.Open();

            // Assert
            Assert.That(System.Data.ConnectionState.Open, Is.EqualTo(connection.State));
        }
        //Assert.Pass();
    }
}