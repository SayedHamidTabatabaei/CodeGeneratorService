using CodeGeneratorService.BodyBuilder.BodyParameterModel;
using System;
using CodeGeneratorService.Interfaces.BodyBuilder;

namespace CodeGeneratorService.BodyBuilder
{
    public class FunctionControlFlowBodyBuilder : BaseBodyBuilder<FunctionControlFlowParameterModel> , IFunctionControlFlowBodyBuilder
    {
        #region Fields

        #endregion

        #region PublicMethods
        public override void Initiate(FunctionControlFlowParameterModel parameter)
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
