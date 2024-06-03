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
    public class OrderService
    {
        private DB_Context _context;

        public OrderService(DB_Context context)
        {
            _context = context;
        }

        public async Task GravarPedido(int brothId, int proteinId)
        {
            try
            {
                var retorno = await _context.sp_InserePedido.FromSqlRaw($"exec sp_InserePedido {brothId}, {proteinId}").ToListAsync();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
