namespace AbstractFactoryExample.Product;

public sealed class SQLServerConnDevelopProduct : SQLServerAbstractProduct
{
    public SQLServerConnDevelopProduct() : base(DataBase.SQLServer, Enums.Environment.Develop)
    {
        ConnectionString = "Data Source=localhost;Initial Catalog=SQLServerDevelop;Integrated Security=True";
    }
}
