using System;
using CodeGeneratorService.BodyBuilder.BodyParameterModel;
using CodeGeneratorService.Interfaces.BodyBuilder;

namespace CodeGeneratorService.BodyBuilder
{
    public class ProcedureInsertBatchBodyBuilder : BaseBodyBuilder<ProcedureInsertBatchParameterModel>, IProcedureInsertBatchBodyBuilder
    {
        #region Fields

        #endregion

        #region PublicMethods
        public override void Initiate(ProcedureInsertBatchParameterModel parameter)
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
