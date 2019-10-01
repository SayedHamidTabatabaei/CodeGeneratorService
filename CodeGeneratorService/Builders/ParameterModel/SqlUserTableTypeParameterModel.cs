using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeGenerator.Share.Enums;

namespace CodeGeneratorService.Builders.ParameterModel
{
    public class SqlUserTableTypeParameterModel
    {
        public string TableName { get; set; }
        public string DataBaseName { get; set; }
        public string SchemaName { get; set; }
        public string Description { get; set; }
        public ActionCategories ActionCategory { get; set; }
        public bool IsExist { get; set; }
        public string ProcedureName => $"[{SchemaName}].[{TableName}_{ActionCategory}]";
    }
}
