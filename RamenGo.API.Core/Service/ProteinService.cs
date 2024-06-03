using Microsoft.EntityFrameworkCore;
using RamenGo.API.Core.Contexto;
using RamenGo.API.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamenGo.API.Core.Service
{
    public class ProteinService
    {
        private DB_Context _context;

        public ProteinService(DB_Context context)
        {
            _context = context;
        }

        public async Task<List<Protein>> ObterProteinas()
        {
            try
            {
                var retorno = await _context.Proteins.ToListAsync();

                var result = retorno.ToList();
                return retorno;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
