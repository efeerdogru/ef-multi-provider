using System.ComponentModel.DataAnnotations;

namespace TestApp
{
    [DbTable("Table1", "TABLE1", "table1")]
    public class Table1
    {
        [DbColumn("Id", "ID", "id")]
        [Key]
        public int Id { get; set; }

        [DbColumn("TestCol", "TEST_COL", "test_col")]
        [Required]
        public string TestCol { get; set; }
    }
}