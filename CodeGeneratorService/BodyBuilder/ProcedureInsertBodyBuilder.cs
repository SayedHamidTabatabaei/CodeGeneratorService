using CodeGeneratorService.BodyBuilder.BodyParameterModel;
using CodeGeneratorService.Interfaces.BodyBuilder;
using System;

namespace CodeGeneratorService.BodyBuilder
{
    public class ProcedureInsertBodyBuilder : BaseBodyBuilder<ProcedureInsertParameterModel>, IProcedureInsertBodyBuilder
    {
        #region Fields

        #endregion

        #region PublicMethods
        public override void Initiate(ProcedureInsertParameterModel parameter)
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
