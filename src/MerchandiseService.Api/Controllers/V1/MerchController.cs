using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MerchandiseService.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace MerchandiseService.Api.Controllers.V1
{
    [ApiController]
    [Route("v1/api/merch")]
    public class MerchController : ControllerBase
    {
        [HttpGet("employee/{id:int}/pack")]
        public Task<ActionResult<MerchPack>> Get(long id, CancellationToken token)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet("employee/{id:int}/packs")]
        public Task<ActionResult<List<MerchPack>>> GetEmployeePacks(long id, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}