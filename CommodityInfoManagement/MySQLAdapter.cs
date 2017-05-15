using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


/// <summary>
/// An adapter for MySQL Database.
/// Please use this in a using blcok, otherwise you should invoke Close() method explicitly.
/// Attention: [Non Thread Safe]
/// </summary>
public class MySqlAdapter : IDisposable
{
    private MySqlConnection SqlConn;
    private MySqlCommand SqlComm;

    public MySqlAdapter()
    {
        SqlConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString);
        SqlConn.Open();
        SqlComm = SqlConn.CreateCommand();
    }

    public int ExecuteNonQuery(string tSql)
    {
        SqlComm.CommandType = CommandType.Text;
        SqlComm.CommandText = tSql;
        return SqlComm.ExecuteNonQuery();
    }

    public void AddParams(MySqlParameter sqlParam)
    {
        SqlComm.Parameters.Add(sqlParam);
    }

    public void AddParams(string ParamName, object Params, MySqlDbType SqlType, int Size, ParameterDirection PD)
    {
        MySqlParameter sqlParam = new MySqlParameter(ParamName, Params);
        sqlParam.MySqlDbType = SqlType;
        sqlParam.Size = Size;
        sqlParam.Direction = PD;
        SqlComm.Parameters.Add(sqlParam);
    }

    public void AddParams(string ParamName, object Params, MySqlDbType SqlType, ParameterDirection PD)
    {
        MySqlParameter sqlParam = new MySqlParameter(ParamName, Params);
        sqlParam.MySqlDbType = SqlType;
        sqlParam.Direction = PD;
        SqlComm.Parameters.Add(sqlParam);
    }

    public DataView GetDataView(string tSql, bool useProc = false)
    {
        MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
        SqlComm.CommandText = tSql;
        SqlComm.CommandType = useProc == true ? CommandType.StoredProcedure : CommandType.Text;
        sqlDataAdapter.SelectCommand = SqlComm;
        DataSet dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet);
        return dataSet.Tables[0].DefaultView;
    }

    public DataRow GetDataRow(string tSql, bool useProc = false)
    {
        MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
        SqlComm.CommandText = tSql;
        SqlComm.CommandType = useProc == true ? CommandType.StoredProcedure : CommandType.Text;
        sqlDataAdapter.SelectCommand = SqlComm;
        DataSet dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet);
        if (dataSet.Tables[0].Rows.Count != 0)
        {
            return dataSet.Tables[0].Rows[0];
        }
        else return null;
    }

    public object ExecuteProcedure(string pSql)
    {
        SqlComm.CommandType = CommandType.StoredProcedure;
        SqlComm.CommandText = pSql;
        SqlComm.Parameters.Add(new MySqlParameter("@RETURN_VALUE", "")).Direction = ParameterDirection.ReturnValue;
        SqlComm.ExecuteNonQuery();
        return SqlComm.Parameters["@RETURN_VALUE"].Value;
    }

    public void ExecProc(string pSql)
    {
        SqlComm.CommandType = CommandType.StoredProcedure;
        SqlComm.CommandText = pSql;
        SqlComm.ExecuteNonQuery();
    }

    public void Close()
    {
        SqlComm.Parameters.Clear();
        if (SqlConn.State != ConnectionState.Closed)
        {
            SqlConn.Close();
        }
    }

    public MySqlParameter GetParam(string paramName)
    {
        return SqlComm.Parameters[paramName];
    }

    public void Dispose()
    {
        SqlComm.Parameters.Clear();
        if (SqlConn.State != ConnectionState.Closed)
        {
            SqlConn.Close();
        }
    }
}