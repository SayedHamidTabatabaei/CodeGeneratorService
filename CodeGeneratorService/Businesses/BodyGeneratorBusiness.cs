using CodeGenerator.Share.Enums;
using CodeGeneratorService.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CodeGeneratorService.Businesses
{
    public class BodyGeneratorBusiness : IBodyGeneratorBusiness
    {
        #region Fields

       // private IIndex<OutputCategories, IBuilder> _builder;

        #endregion

        public string Get<TParameter>(TParameter parameter)
        {
            return string.Empty;
        }

        public string Get<TParameter>(TParameter parameter, ActionCategories actionCategories)
        {
            return string.Empty;
        }

        #region Private Methods

        private IBuilder GetBuilder()
        {
            return new Builders.ICSharpApiCoreBuilder();
        }

        #endregion
    }
}
