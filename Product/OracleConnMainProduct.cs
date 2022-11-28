namespace AbstractFactoryExample.Product;

public sealed class OracleConnMainProduct : OracleAbstractProduct
{
    public OracleConnMainProduct() : base(DataBase.Oracle, Enums.Environment.Main)
    {
        ConnectionString = "Data Source=localhost;Initial Catalog=OracleMain;Integrated Security=True";
    }
}
