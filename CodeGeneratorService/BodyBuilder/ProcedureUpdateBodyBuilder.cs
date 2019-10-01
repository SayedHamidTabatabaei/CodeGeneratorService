using System;
using CodeGeneratorService.BodyBuilder.BodyParameterModel;
using CodeGeneratorService.Interfaces.BodyBuilder;

namespace CodeGeneratorService.BodyBuilder
{
    public class ProcedureUpdateBodyBuilder : BaseBodyBuilder<ProcedureUpdateParameterModel>, IProcedureUpdateBodyBuilder
    {
        #region Fields

        #endregion

        #region PublicMethods
        public override void Initiate(ProcedureUpdateParameterModel parameter)
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
