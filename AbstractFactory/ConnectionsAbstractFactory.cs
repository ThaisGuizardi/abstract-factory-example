namespace AbstractFactoryExample.AbstractFactory;

public abstract class ConnectionsAbstractFactory
{
    public abstract ConnectionBase CreateConnection(DataBase dataBaseType);

    public static ConnectionsAbstractFactory CreateConnAbstractFactory(DataBase dataBaseType)
    {
        switch (dataBaseType)
        {
            case DataBase.SQLServer:
                return new SQLServerConcreteFactory();
            case DataBase.Oracle:
                return new OracleConcreteFactory();
            default:
                throw new ArgumentOutOfRangeException("Connection not found");
        }
    }
}
