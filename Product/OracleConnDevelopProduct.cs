namespace AbstractFactoryExample.Product;

public sealed class OracleConnDevelopProduct : OracleAbstractProduct
{
    public OracleConnDevelopProduct() : base(DataBase.Oracle, Enums.Environment.Develop)
    {
        ConnectionString = "Data Source=localhost;Initial Catalog=OracleDevelop;Integrated Security=True";
    }
}
