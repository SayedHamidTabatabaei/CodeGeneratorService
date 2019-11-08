using CodeGenerator.Share.Enums;
using CodeGeneratorService.Builders.ParameterModel;
using CodeGeneratorService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace CodeGeneratorService.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]s")]
    [ApiController]
    public class ProcedureController : ControllerBase
    {
        #region Fields

        private readonly IGeneratorBusiness _generatorBusiness;

        #endregion

        #region constructor 

        public ProcedureController(IGeneratorBusiness generatorBusiness)
        {
            _generatorBusiness = generatorBusiness;
        }

        #endregion

        /// <summary>
        /// Get all procedures for input table name
        /// </summary>
        /// <param name="tableNames">Table name that we want procedures</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> Get(List<string> tableNames)
        {
            return "";
        }

        [HttpGet]
        public ActionResult<string> Get(List<string> tableNames, ActionCategories actionCategories)
        {
            var sqlProcedureParameterModel = new SqlProcedureParameterModel { ActionCategory = actionCategories, };

            return _generatorBusiness.Get(sqlProcedureParameterModel, actionCategories);
        }

    }
}