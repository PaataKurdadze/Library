using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DatabaseHelper;
using Library.DTO;


namespace Library.Repository
{
  public abstract class BaseRepository<T> where T : new()
  {
    protected readonly Database _database;
    protected readonly Type _dtoType;


    protected BaseRepository(Database database)
    {
      _database = database ?? throw new ArgumentNullException(nameof(database));
      _dtoType = typeof(T);
    }

    protected virtual string InsertProcedureName => $"Insert{_dtoType.Name}_SP";
    protected virtual string DeleteProcedureName => $"Delete{_dtoType.Name}_SP";
    protected virtual string UpdateProcedureName => $"Update{_dtoType.Name}_SP";
    protected virtual string GetProcedureName => $"Get{_dtoType.Name}_SP";
    protected virtual string SelectProcedureName => $"Select{_dtoType.Name}_SP";

    public int Insert(T dto)
    {
      var parameters = GetParamNames(InsertProcedureName);
      var properties = _dtoType.GetProperties();

      return Convert.ToInt32(_database.ExecuteScalar(
        InsertProcedureName,
        CommandType.StoredProcedure,
        GetParametersFromProperties(dto, parameters, properties).ToArray()
      ));
    }

    public void Update(T dto)
    {
      var parameters = GetParamNames(UpdateProcedureName);
      var properties = _dtoType.GetProperties();

      _database.ExecuteScalar(
          UpdateProcedureName,
          CommandType.StoredProcedure,
          GetParametersFromProperties(dto, parameters, properties).ToArray()
      );
    }

    public void Delete(int id)
    {
      _database.ExecuteScalar(
          DeleteProcedureName,
          CommandType.StoredProcedure,
          new SqlParameter(String.Concat(_dtoType.Name, "ID"), id)
      );
    }

    public T GetByID(int id, bool readDeleted = false)
    {
      using (var reader = _database.ExecuteReader(GetProcedureName, CommandType.StoredProcedure,
        new SqlParameter($"ID", id),
        new SqlParameter($"ReadDeleted", readDeleted)
      ))
      {
        if (reader.Read())
        {
          return GetDTO(reader);
        }
        return default;
      }
    }

    public IEnumerable<T> Load(bool readDeleted = false)
    {
      using (var reader = _database.ExecuteReader(SelectProcedureName, CommandType.StoredProcedure,
        new SqlParameter($"ReadDeleted", readDeleted)
      ))
      {
        while (reader.Read())
        {
          yield return GetDTO(reader);
        }
      }
    }


    #region Helper methods

    private static List<SqlParameter> GetParametersFromProperties(T dto, IEnumerable<string> parameters, PropertyInfo[] properties)
    {
      var sqlParameters = new List<SqlParameter>();

      foreach (var prop in properties)
      {
        if (parameters.Contains(prop.Name.Insert(0, "@")))
        {
          sqlParameters.Add(new SqlParameter(prop.Name, prop.GetValue(dto)));
        }
      }

      return sqlParameters;
    }

    private IEnumerable<string> GetParamNames(string procedureName)
    {
      var cmd = _database.GetCommand(procedureName, CommandType.StoredProcedure);
      _database.GetConnection().Open();

      try
      {
        SqlCommandBuilder.DeriveParameters(cmd);
        foreach (SqlParameter sqlParam in cmd.Parameters)
          yield return sqlParam.ParameterName;
      }
      finally
      {
        _database.GetConnection().Close();
      }
    }

    protected T GetDTO(SqlDataReader reader)
    {
      var properties = _dtoType.GetProperties();
      T dto = new T();
      foreach (var propInfo in properties)
      {
        propInfo.SetValue(dto, reader[propInfo.Name]);
      }
      return dto;
    }

    #endregion

  }
}
