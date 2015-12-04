using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp
{
    internal class DbColumnAttribute : ColumnAttribute
    {
        public DbColumnAttribute(string msSqlName, string oracleName, string postgreSqlName)
            : base(Tools.DbProvider == DbProviders.MsSql
                ? msSqlName
                : Tools.DbProvider == DbProviders.Oracle
                    ? oracleName
                    : Tools.DbProvider == DbProviders.PostgreSql
                        ? postgreSqlName
                        : null) {}
    }
}