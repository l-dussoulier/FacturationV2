using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FactureController : ControllerBase
    {
        private readonly ILogger<FactureController> _logger;
        private readonly IBusinessData _data;

        
        public FactureController(ILogger<FactureController> logger,IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            return _data.lesFactures;
        }

        [HttpGet("{numero}")]
        public ActionResult<Facture> Get(string numero)
        {
            var facture = _data.lesFactures.Where(sp => sp.Numero == numero).FirstOrDefault();
            
            if (facture != null)
            {
                return facture;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Facture> Post([FromQuery] Facture newFacture)
        {
            if (ModelState.IsValid)
            {
                return Created($"Facture/{newFacture.Numero}",newFacture);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }
    }
}
