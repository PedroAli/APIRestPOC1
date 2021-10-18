using AR.Data.Interfaces;
using AR.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AS.Apresentacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaController(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Categoria categoria)
        {
            
            try
            {
                await _repository.Add(categoria);
                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }
    }
}
