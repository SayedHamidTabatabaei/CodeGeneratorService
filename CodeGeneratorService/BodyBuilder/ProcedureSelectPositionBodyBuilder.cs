using CodeGeneratorService.BodyBuilder.BodyParameterModel;
using System;
using CodeGeneratorService.Interfaces.BodyBuilder;

namespace CodeGeneratorService.BodyBuilder
{
    public class ProcedureSelectPositionBodyBuilder : BaseBodyBuilder<ProcedureSelectPositionParameterModel>, IProcedureSelectPositionBodyBuilder
    {
        #region Fields

        #endregion

        #region PublicMethods
        public override void Initiate(ProcedureSelectPositionParameterModel parameter)
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
