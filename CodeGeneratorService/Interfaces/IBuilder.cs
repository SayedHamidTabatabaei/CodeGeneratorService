using CodeGenerator.Share.Enums;

namespace CodeGeneratorService.Interfaces
{
    public interface IBuilder
    {
        string Build();

        string BuildFile();
    }

    public interface IBuilder<in TParameter> : IBuilder where TParameter: class
    {
        void Initiate(TParameter parameter);
    }

    public delegate IBuilder BuilderResolver(OutputCategories key);
}
