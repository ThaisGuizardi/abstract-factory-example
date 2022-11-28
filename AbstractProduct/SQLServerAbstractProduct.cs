namespace AbstractFactoryExample.AbstractProduct;

public abstract class SQLServerAbstractProduct : ConnectionBase
{
    protected SQLServerAbstractProduct(DataBase dataBaseType, Enums.Environment environment) : base(dataBaseType, environment)
    {
    }
}
