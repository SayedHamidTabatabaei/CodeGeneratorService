using CodeGeneratorService.Builders.ParameterModel;
using System;
using CodeGeneratorService.Interfaces.Builders;

namespace CodeGeneratorService.Builders
{
    public class CSharpUserTableTypeBuilder : BaseBuilder<CSharpUserTableTypeParameterModel>, ICSharpUserTableTypeBuilder
    {
        #region Fields

        private static DateTime CreatedDateTime { get; set; }
        private static CSharpUserTableTypeParameterModel Parameter { get; set; }

        #endregion

        #region PublicMethods

        public override void Initiate(CSharpUserTableTypeParameterModel parameter)
        {
            Parameter = parameter;

            if (Parameter.IsExist)
            {
                CreatedDateTime = DateTime.UtcNow;
            }
        }

        public override string Build()
        {
            return $"{BuildProcedureHeader()}\r\n{(Parameter.IsExist ? BuildAlterProcedure() : BuildCreateProcedure())}\r\n(\r\n{BuildParameters()}\r\n)\r\nAS\r\nBEGIN\r\n{BuildBody()}\r\nEND";
        }

        public override string BuildFile()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region PrivateMethods

        private static string BuildProcedureHeader()
        {
            return $@"USE [{Parameter.DataBaseName}]
GO
/****** Object:  StoredProcedure {Parameter.ProcedureName}    Script Date: {DateTime.Now} ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------------------------------
--Author       :   {CodeGenerator.Share.Constants.CodeBuilders.Author}
--Create Date  :   {CreatedDateTime}
--Description  :   {Parameter.Description}
------------------------------------------------------------------------------------------";
        }

        private static string BuildAlterProcedure()
        {
            return $"ALTER PROCEDURE {Parameter.ProcedureName}";
        }

        private static string BuildCreateProcedure()
        {
            return $"CREATE PROCEDURE {Parameter.ProcedureName}";
        }

        private static string BuildParameters()
        {
            return string.Empty;
        }

        private static string BuildBody()
        {
            return string.Empty;
        }

        #endregion
    }
}
