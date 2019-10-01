using CodeGeneratorService.BodyBuilder.BodyParameterModel;
using System;
using CodeGeneratorService.Interfaces.BodyBuilder;

namespace CodeGeneratorService.BodyBuilder
{
    public class ProcedureSelectFunctionBodyBuilder : BaseBodyBuilder<ProcedureSelectFunctionParameterModel>, IProcedureSelectFunctionBodyBuilder
    {
        #region Fields

        #endregion

        #region PublicMethods
        public override void Initiate(ProcedureSelectFunctionParameterModel parameter)
        {
            throw new NotImplementedException();
        }

        public override string Build()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region PrivateMethods

        #endregion
    }
}
