using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DB;

namespace modeloVirtualCChar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly GestorBibliotecaContext _context;

        public UsuariosController(GestorBibliotecaContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
          if (_context.Usuarios == null)
          {
              return NotFound();
          }
            return await _context.Usuarios.ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(long id)
        {
          if (_context.Usuarios == null)
          {
              return NotFound();
          }
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(long id, Usuario usuario)
        {
            if (id != usuario.id_usuario)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
          if (_context.Usuarios == null)
          {
              return Problem("Entity set 'GestorBibliotecaContext.Usuarios'  is null.");
          }
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.id_usuario }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(long id)
        {
            if (_context.Usuarios == null)
            {
                return NotFound();
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(long id)
        {
            return (_context.Usuarios?.Any(e => e.id_usuario == id)).GetValueOrDefault();
        }

		// GET: api/Usuarios/correo
		[HttpGet("correo/{correo}")]
		public async Task<ActionResult<Usuario>> GetUsuarioByCorreo(string correo)
		{
			if (_context.Usuarios == null)
			{
				return NotFound();
			}
			var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.email_usuario == correo);

			if (usuario == null)
			{
				return NotFound();
			}

			return usuario;
		}
		// GET: api/Usuarios/dni
		[HttpGet("dni/{dni}")]
		public async Task<ActionResult<Usuario>> GetUsuarioByDni(string dni)
		{
			if (_context.Usuarios == null)
			{
				return NotFound();
			}
			var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.dni_usuario == dni);

			if (usuario == null)
			{
				return NotFound();
			}

			return usuario;
		}
		// GET: api/Usuarios/telefono
		[HttpGet("telefono/{telefono}")]
		public async Task<ActionResult<Usuario>> GetUsuarioByTelefono(string telefono)
		{
			if (_context.Usuarios == null)
			{
				return NotFound();
			}
			var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.tlf_usuario == telefono);

			if (usuario == null)
			{
				return NotFound();
			}

			return usuario;
		}
	}
}
