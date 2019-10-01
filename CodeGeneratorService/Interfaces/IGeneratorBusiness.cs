using CodeGenerator.Share.Enums;

namespace CodeGeneratorService.Interfaces
{
    public interface IGeneratorBusiness
    {
        string Get<TParameter>(TParameter parameter);

        string Get<TParameter>(TParameter parameter, ActionCategories actionCategories);
    }
}