using CodeGenerator.Share.Enums;

namespace CodeGeneratorService.Interfaces
{
    public interface IBodyBuilder
    {
        string Build();
    }

    public interface IBodyBuilder<in TParameter> : IBodyBuilder where TParameter : class
    {
        void Initiate(TParameter parameter);
    }

    public delegate IBodyBuilder BodyBuilderResolver(ActionCategories key);
}
