using Microsoft.AspNetCore.Mvc;
using RamenGo.API.Core.Model;
using RamenGo.API.Core.Service;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using RamenGo.API.Core.DTO;

namespace RamenGo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task GravarPedido([FromBody] OrderDTO infoOrder)
        {
            try
            {
                await _orderService.GravarPedido(infoOrder.BrothId, infoOrder.ProteinId);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
