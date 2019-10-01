using CodeGeneratorService.Interfaces;

namespace CodeGeneratorService.BodyBuilder
{
    public abstract class BaseBodyBuilder<TParameter> : IBodyBuilder<TParameter> where TParameter : class
    {
        public abstract void Initiate(TParameter parameter);

        public abstract string Build();
    }
}
