using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace TestApp
{
    internal class DbTableAttribute : TableAttribute
    {
        public DbTableAttribute(string msSqlName, string oracleName, string postgreSqlName, string msSqlSchema = null, string oracleSchema = null, string postgreSqlSchema = null)
            : base(Tools.DbProvider == DbProviders.MsSql
                ? msSqlName
                : Tools.DbProvider == DbProviders.Oracle
                    ? oracleName
                    : Tools.DbProvider == DbProviders.PostgreSql
                        ? postgreSqlName
                        : null)
        {
            switch (Tools.DbProvider)
            {
                case DbProviders.MsSql:
                    Schema = (msSqlSchema ?? ConfigurationManager.AppSettings["DefaultDbSchema"]) ?? "dbo";
                    break;
                case DbProviders.Oracle:
                    Schema = (oracleSchema ?? ConfigurationManager.AppSettings["DefaultDbSchema"]);
                    break;
                case DbProviders.PostgreSql:
                    Schema = (postgreSqlSchema ?? ConfigurationManager.AppSettings["DefaultDbSchema"]);
                    break;
            }
        }
    }
}