using CodeGenerator.Share.Enums;
using CodeGeneratorService.BodyBuilder;
using CodeGeneratorService.Interfaces;
using CodeGeneratorService.Interfaces.BodyBuilder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace CodeGeneratorService.Extensions
{
    public static class ServiceBodyBuilderExtensions
    {
        public static IServiceCollection RegisterBodyBuilder(this IServiceCollection services)
        {
            services.AddTransient<IFunctionControlFlowBodyBuilder, FunctionControlFlowBodyBuilder>();
            services.AddTransient<IFunctionGetChildCountBodyBuilder, FunctionGetChildCountBodyBuilder>();
            services.AddTransient<IFunctionGetListOfChildrenBodyBuilder, FunctionGetListOfChildrenBodyBuilder>();
            services.AddTransient<IFunctionGetMaxChildIdBodyBuilder, FunctionGetMaxChildIdBodyBuilder>();
            services.AddTransient<IFunctionGetMaxPriorityBodyBuilder, FunctionGetMaxPriorityBodyBuilder>();
            services.AddTransient<IFunctionGetParentInfoBodyBuilder, FunctionGetParentInfoBodyBuilder>();
            services.AddTransient<IFunctionValidationBatchForAddEditDeleteBodyBuilder, FunctionValidationBatchForAddEditDeleteBodyBuilder>();
            services.AddTransient<IFunctionValidationBatchPreSaveBodyBuilder, FunctionValidationBatchPreSaveBodyBuilder>();
            services.AddTransient<IFunctionValidationForAddEditDeleteBodyBuilder, FunctionValidationForAddEditDeleteBodyBuilder>();
            services.AddTransient<IFunctionValidationBatchPreSaveBodyBuilder, FunctionValidationBatchPreSaveBodyBuilder>();
            services.AddTransient<IProcedureDeleteBatchBodyBuilder, ProcedureDeleteBatchBodyBuilder>();
            services.AddTransient<IProcedureDeleteBodyBuilder, ProcedureDeleteBodyBuilder>();
            services.AddTransient<IProcedureDeleteConditionalBodyBuilder, ProcedureDeleteConditionalBodyBuilder>();
            services.AddTransient<IProcedureInsertBatchBodyBuilder, ProcedureInsertBatchBodyBuilder>();
            services.AddTransient<IProcedureInsertBodyBuilder, ProcedureInsertBodyBuilder>();
            services.AddTransient<IProcedureSelectAllBodyBuilder, ProcedureSelectAllBodyBuilder>();
            services.AddTransient<IProcedureSelectByPkBodyBuilder, ProcedureSelectByPkBodyBuilder>();
            services.AddTransient<IProcedureSelectCalculationBodyBuilder, ProcedureSelectCalculationBodyBuilder>();
            services.AddTransient<IProcedureSelectFunctionBodyBuilder, ProcedureSelectFunctionBodyBuilder>();
            services.AddTransient<IProcedureSelectPagedBodyBuilder, ProcedureSelectPagedBodyBuilder>();
            services.AddTransient<IProcedureSelectPositionBodyBuilder, ProcedureSelectPositionBodyBuilder>();
            services.AddTransient<IProcedureUpdateBodyBuilder, ProcedureUpdateBodyBuilder>();
            services.AddTransient<IProcedureUpdateBatchBodyBuilder, ProcedureUpdateBatchBodyBuilder>();
            services.AddTransient<IProcedureUpdateConditionalBodyBuilder, ProcedureUpdateConditionalBodyBuilder>();

            services.AddTransient<BodyBuilderResolver>(serviceProvider => key =>
            {
                switch (key)
                {
                    case ActionCategories.ControlFlow:
                        return serviceProvider.GetService<IFunctionControlFlowBodyBuilder>();
                    case ActionCategories.GetChildCount:
                        return serviceProvider.GetService<IFunctionGetChildCountBodyBuilder>();
                    case ActionCategories.ListOfChildren:
                        return serviceProvider.GetService<IFunctionGetListOfChildrenBodyBuilder>();
                    case ActionCategories.GetMaxChildId:
                        return serviceProvider.GetService<IFunctionGetMaxChildIdBodyBuilder>();
                    case ActionCategories.GetMaxPriority:
                        return serviceProvider.GetService<IFunctionGetMaxPriorityBodyBuilder>();
                    case ActionCategories.GetParentInfo:
                        return serviceProvider.GetService<IFunctionGetParentInfoBodyBuilder>();
                    case ActionCategories.ValidationBatchForAddEditDelete:
                        return serviceProvider.GetService<IFunctionValidationBatchForAddEditDeleteBodyBuilder>();
                    case ActionCategories.ValidationBatchPreSave:
                        return serviceProvider.GetService<IFunctionValidationBatchPreSaveBodyBuilder>();
                    case ActionCategories.ValidationForAddEditDelete:
                        return serviceProvider.GetService<IFunctionValidationForAddEditDeleteBodyBuilder>();
                    case ActionCategories.ValidationPreSave:
                        return serviceProvider.GetService<IFunctionValidationBatchPreSaveBodyBuilder>();
                    case ActionCategories.DeleteBatch:
                        return serviceProvider.GetService<IProcedureDeleteBatchBodyBuilder>();
                    case ActionCategories.Delete:
                        return serviceProvider.GetService<IProcedureDeleteBodyBuilder>();
                    case ActionCategories.DeleteConditional:
                        return serviceProvider.GetService<IProcedureDeleteConditionalBodyBuilder>();
                    case ActionCategories.InsertBatch:
                        return serviceProvider.GetService<IProcedureInsertBatchBodyBuilder>();
                    case ActionCategories.Insert:
                        return serviceProvider.GetService<IProcedureInsertBodyBuilder>();
                    case ActionCategories.SelectAll:
                        return serviceProvider.GetService<IProcedureSelectAllBodyBuilder>();
                    case ActionCategories.SelectByPk:
                        return serviceProvider.GetService<IProcedureSelectByPkBodyBuilder>();
                    case ActionCategories.SelectCalculation:
                        return serviceProvider.GetService<IProcedureSelectCalculationBodyBuilder>();
                    case ActionCategories.SelectFunction:
                        return serviceProvider.GetService<IProcedureSelectFunctionBodyBuilder>();
                    case ActionCategories.SelectPaged:
                        return serviceProvider.GetService<IProcedureSelectPagedBodyBuilder>();
                    case ActionCategories.SelectPosition:
                        return serviceProvider.GetService<IProcedureSelectPositionBodyBuilder>();
                    case ActionCategories.Update:
                        return serviceProvider.GetService<IProcedureUpdateBodyBuilder>();
                    case ActionCategories.UpdateBatch:
                        return serviceProvider.GetService<IProcedureUpdateBatchBodyBuilder>();
                    case ActionCategories.UpdateConditional:
                        return serviceProvider.GetService<IProcedureUpdateConditionalBodyBuilder>();
                    default:
                        throw new KeyNotFoundException(); // or maybe return null, up to you
                }
            });

            return services;
        }
    }
}