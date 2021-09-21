using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using prestasmosApi.Models;

namespace _2019AP601.Controllers
{
    [ApiController] 
    public class equiposController : ControllerBase
    {
        private readonly _2019APContext _contexto;

        public equiposController(_2019AP601Context miContexto) {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/equipos")]
        public IActionResult Get(){
            var equiposList = _contexto.equipos;
            if(equiposList.Count>0){
                return Ok(equiposList);
            }
            return NotFound();            
        } 

    }
}