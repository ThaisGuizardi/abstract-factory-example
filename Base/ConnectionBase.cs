namespace AbstractFactoryExample.Base;

public abstract class ConnectionBase
{
    public DataBase DataBaseType { get; set; }

    public string ConnectionString { get; set; }

    public Enums.Environment Environment { get; set; }

    public ConnectionBase(DataBase dataBaseType, Enums.Environment environment)
    {
        DataBaseType = dataBaseType;
        Environment = environment;
    }
}
