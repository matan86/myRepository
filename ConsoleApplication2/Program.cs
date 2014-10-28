using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
        public static string GetStringFromDB(string key, string cultureCode)
{
if (SqlHelperClass.IsConnectionStringInitialized)
{
    QueryDataParameters queryParams = new QueryDataParameters();
    queryParams.Add("@stringKey", key);
    queryParams.Add("@cultureCode", cultureCode);
    DataSet dataSource = SqlHelperClass.ExecuteQuery("Proc_CMS_SqlResourceManager_GetStringByKey", queryParams, QueryTypeEnum.StoredProcedure);
    if (!SystemDataHelper.DataSourceIsEmpty(dataSource))
    {
        return dataSource.Tables[0].Rows[0]["TranslationText"].ToString();
    }
}
return null;
}


        }
    }
}
