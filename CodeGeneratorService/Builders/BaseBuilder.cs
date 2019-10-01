using CodeGeneratorService.Interfaces;

namespace CodeGeneratorService.Builders
{
    public abstract class BaseBuilder<TParameter> : IBuilder<TParameter> where TParameter : class
    {
        public abstract void Initiate(TParameter parameter);

        public abstract string Build();

        public abstract string BuildFile();
    }
}
