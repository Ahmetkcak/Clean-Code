using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingAbstractions;

public abstract class BaseDb
{
    public BaseDb()
    {
          
    }
    public abstract string GetDbVersion();
    public DataTable ExecuteSql(string sql)
    {
        // generate sql
        return new DataTable();
    }
}
public class SqlServerDb : BaseDb
{
    public override string GetDbVersion() => "SqlServer 2015";

    public string GenerateSql(int id)
    {
        return $"SELECT * FROM USERS WITH (NOLOCK) WHERE Id = {id}";
    }
}

public class OracleDb : BaseDb
{
    public override string GetDbVersion() => "Oracle 18c";

}

public class MySqlDb : BaseDb 
{
    public override string GetDbVersion() => "MySql Databaes";
}

