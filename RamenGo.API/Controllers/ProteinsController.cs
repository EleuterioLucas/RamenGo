using Microsoft.AspNetCore.Mvc;
using RamenGo.API.Core.Model;
using RamenGo.API.Core.Service;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RamenGo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProteinsController : Controller
    {
        private ProteinService _proteinService;

        public ProteinsController(ProteinService proteinService)
        {
            _proteinService = proteinService;
        }

        [HttpGet]
        public async Task<List<Protein>> ObterMolhos()
        {
            try
            {
                List<Protein> retorno = await _proteinService.ObterProteinas();

                return retorno;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
