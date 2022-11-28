namespace AbstractFactoryExample.AbstractProduct;

public abstract class OracleAbstractProduct : ConnectionBase
{
    protected OracleAbstractProduct(DataBase dataBaseType, Enums.Environment environment) : base(dataBaseType, environment)
    {
    }
}
