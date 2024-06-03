using Microsoft.AspNetCore.Mvc;
using RamenGo.API.Core.Model;
using RamenGo.API.Core.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RamenGo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrothsController : Controller
    {
        private BrothService _brothService;

        public BrothsController(BrothService brothService)
        {
            _brothService = brothService;
        }

        [HttpGet]
        public async Task<List<Broth>> ObterMolhos()
        {
            try
            {
                List<Broth> retorno = await _brothService.ObterMolhos();

                return retorno;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
