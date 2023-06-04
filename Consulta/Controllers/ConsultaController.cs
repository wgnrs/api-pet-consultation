using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulta.Application;
using Microsoft.AspNetCore.Mvc;

namespace Consulta.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultaController : ControllerBase
    {
        private readonly ConsultaApplicationService _consultaApplicationService;

        public ConsultaController(ConsultaApplicationService consultaApplicationService)
        {
            _consultaApplicationService = consultaApplicationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ConsultaNames>>> GetConsultaNames()
        {
            var consultaNames = await _consultaApplicationService.GetConsultaNames();
            return consultaNames;
        }
    }
}