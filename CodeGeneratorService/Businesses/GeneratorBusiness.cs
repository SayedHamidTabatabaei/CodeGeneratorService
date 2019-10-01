using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeGenerator.Share.Enums;
using CodeGeneratorService.Interfaces;

namespace CodeGeneratorService.Businesses
{
    public class GeneratorBusiness : IGeneratorBusiness
    {
        public string Get<TParameter>(TParameter parameter)
        {
            return string.Empty;
        }

        public string Get<TParameter>(TParameter parameter, ActionCategories actionCategories)
        {
            return string.Empty;
        }
    }
}
