namespace AbstractFactoryExample.Product;

public sealed class SQLServerConnMainProduct : SQLServerAbstractProduct
{
    public SQLServerConnMainProduct() : base(DataBase.SQLServer, Enums.Environment.Main)
    {
        ConnectionString = "Data Source=localhost;Initial Catalog=SQLServerMain;Integrated Security=True";
    }
}
