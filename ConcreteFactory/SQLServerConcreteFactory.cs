namespace AbstractFactoryExample.ConcreteFactory;

public sealed class SQLServerConcreteFactory : ConnectionsAbstractFactory
{
    public override ConnectionBase CreateConnection(DataBase dataBaseType)
    {
        var sqlServerConnType = (Enums.Environment)dataBaseType;

        switch (sqlServerConnType)
        {
            case Enums.Environment.Main:
                return new SQLServerConnMainProduct();
            case Enums.Environment.Develop:
                return new SQLServerConnDevelopProduct();
            default:
                throw new ArgumentOutOfRangeException("Connection not found");
        }

    }
}
