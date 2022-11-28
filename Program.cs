
// Get factories
var oracleConcreteFactory = ConnectionsAbstractFactory.CreateConnAbstractFactory(DataBase.Oracle);
var sqlServerConcreteFactory = ConnectionsAbstractFactory.CreateConnAbstractFactory(DataBase.SQLServer);

// Create oracle objects
var oracleMainEnvironment = oracleConcreteFactory.CreateConnection((DataBase)AbstractFactoryExample.Enums.Environment.Main);
var oracleDevelopEnvironment = oracleConcreteFactory.CreateConnection((DataBase)AbstractFactoryExample.Enums.Environment.Develop);

// Create sql server objects
var sqlServerMainEnvironment = sqlServerConcreteFactory.CreateConnection((DataBase)AbstractFactoryExample.Enums.Environment.Main);
var sqlServerDevelopEnvironment = sqlServerConcreteFactory.CreateConnection((DataBase)AbstractFactoryExample.Enums.Environment.Develop);

// Show details
ShowConnections(oracleMainEnvironment);
ShowConnections(oracleDevelopEnvironment);
ShowConnections(sqlServerMainEnvironment);
ShowConnections(sqlServerDevelopEnvironment);

Console.ReadLine();

static void ShowConnections(ConnectionBase connectionBase)
{
    Console.WriteLine($"Data Base Type: {connectionBase.DataBaseType}");
    Console.WriteLine($"Environment: {connectionBase.Environment}");
    Console.WriteLine($"ConnectionString: {connectionBase.ConnectionString}");

    Console.WriteLine("\n");
}

#region References

// https://macoratti.net/21/07/c_abstrfactory1.htm

// https://www.dofactory.com/net/abstract-factory-design-pattern

// https://www.youtube.com/watch?v=-gpfanU8gRI

// https://www.youtube.com/watch?v=Drsg4orEo8Y

// https://www.youtube.com/watch?v=p5r-cB29Clc

#endregion