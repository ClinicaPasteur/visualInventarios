using Inventarios_BE.Entidades;
using Inventarios_BE.Filtros;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace Inventarios_BE.Controllers
{
    [Route("api/productos")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductosController: ControllerBase
    {
        private readonly ILogger<ProductosController> logger;
        private readonly ApplicationDbContext db;

        public ProductosController(ILogger<ProductosController> logger,
            ApplicationDbContext db)
        {
            this.logger = logger;
            this.db = db;
        }

        [HttpGet]
        //[ResponseCache(Duration = 60)]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            return await db.Productos.ToListAsync();
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Producto>> Get(Int64 id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Producto producto)
        {
            db.Add(producto);
            await db.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut]
        public ActionResult Put([FromBody] Producto producto)
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
