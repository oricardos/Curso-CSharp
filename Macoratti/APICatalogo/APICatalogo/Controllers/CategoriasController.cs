using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            //return _context.Categorias.Include(c => c.Produtos).ToList();
            return _context.Categorias.Include(p => p.Produtos).Where(c => c.CategoriaId <= 5).ToList();
        }

        /// <summary>
        /// Retorna todas as categorias.
        /// </summary>
        /// <returns>
        /// Retorna:
        /// - 200 (OK):Todas as categorias.
        /// - 404 (Bad Request): Quando o ID da URL é diferente do ID do objeto enviado.
        /// </returns>
        /// <response code="200">Retorna todas as categorias</response>
        /// <response code="404">Nenhuma categoria encontrada</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            var categorias = _context.Categorias.AsNoTracking().ToList();
            if (categorias is null)
            {
                return NotFound("Nenhuma categoria foi encontada!");
            }

            return categorias;
        }

        /// <summary>
        /// Retorna uma categoria específica pelo ID.
        /// </summary>
        /// <param name="id">
        /// Identificador da categoria a ser atualizada. Deve ser igual ao ID informado no objeto categoria.
        /// </param>
        /// <returns>
        /// Retorna:
        /// - 200 (OK): Objeto da categoria encontrada.
        /// - 400 (Bad Request): Quando o ID da URL é diferente do ID do objeto enviado.
        /// </returns>
        /// <response code="200">Retorna a categoria encontrada</response>
        /// <response code="404">Nenhuma categoria encontrada</response>
        [HttpGet("{id:int}", Name="ObterCategoria")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Categoria> Get(int id)
        {
            var produto = _context.Categorias.FirstOrDefault(p => p.CategoriaId == id);
            if (produto is null)
            {
                return NotFound("Nenhuma categoria foi encontrada!");
            }

            return produto;
        }

        /// <summary>
        /// Adiciona uma nova categoria.
        /// </summary>
        /// <param name="categoria">
        /// Objeto categoria para ser criado.
        /// </param>
        /// <returns>
        /// Retorna:
        /// - 201 (OK): Objeto da categoria criada.
        /// - 400 (Bad Request): Quando o ID da URL é diferente do ID do objeto enviado.
        /// </returns>
        /// <response code="201">Retorna a categoria criada.</response>
        /// <response code="400">O objeto da categoria é null.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Post(Categoria categoria)
        {
            if (categoria is null)
            {
                return BadRequest();
            }

            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterCategoria", new { id = categoria.CategoriaId }, categoria);
        }

        /// <summary>
        /// Atualiza uma categoria específica com novos valores.
        /// </summary>
        /// <param name="id">
        /// Identificador da categoria a ser atualizada. Deve ser igual ao ID informado no objeto categoria.
        /// </param>
        /// <returns>
        /// Retorna:
        /// - 200 (OK): Quando a categoria é atualizada com sucesso.
        /// - 400 (Bad Request): Quando o ID da URL é diferente do ID do objeto enviado.
        /// </returns>
        /// <response code="200">Categoria atualizada com sucesso</response>
        /// <response code="400">Os IDs informados são diferentes</response>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Put(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                return BadRequest("Os IDs não conferem.");
            }

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(categoria);
        }

        /// <summary>
        /// Remove uma categoria específica à partir do seu id.
        /// </summary>
        /// <param name="id">
        /// Identificador da categoria a ser removida.
        /// </param>
        /// <returns>
        /// Retorna:
        /// - 200 (OK): Quando a categoria é removida com sucesso.
        /// - 404 (Not Found): Quando a categoria não for encontrada.
        /// </returns>
        /// <response code="200">Categoria removida com sucesso</response>
        /// <response code="404">Categoria não encontrada</response>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);

            if (categoria is null)
            {
                return NotFound("Categoria não encontrada.");
            }

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return Ok(categoria);
        }
    }
}
