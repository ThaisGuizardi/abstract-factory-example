namespace AbstractFactoryExample.ConcreteFactory;

public sealed class OracleConcreteFactory : ConnectionsAbstractFactory
{
    public override ConnectionBase CreateConnection(DataBase dataBaseType)
    {
        var oracleConnType = (Enums.Environment)dataBaseType;

        switch (oracleConnType)
        {
            case Enums.Environment.Main:
                return new OracleConnMainProduct();
            case Enums.Environment.Develop:
                return new OracleConnDevelopProduct();
            default:
                throw new ArgumentOutOfRangeException("Connection not found");
        }
    }
}
