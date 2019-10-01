using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeGenerator.Share.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeGeneratorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedureController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get(List<string> tableNames)
        {
            return "";
        }

        [HttpGet]
        public ActionResult<string> Get(List<string> tableNames, ActionCategories actionCategories)
        {
            return "";
        }

    }
}