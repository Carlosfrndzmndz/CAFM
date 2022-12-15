using AutoMapper;
using CAFM.Models;
using CAFM.Models.Dtos;
using CAFM.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Mvc;

namespace CAFM.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IMapper _mapper;

        public UsuariosController(IUsuarioRepositorio usuarioRepositorio,IMapper mapper)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetUsuarios()
        {
            var listaUsuarios = _usuarioRepositorio.GetUsuarios();

            var listaUsuariosDto = new List<UsuarioDto_cs>();

            foreach (var lista in listaUsuarios)
            {
                listaUsuariosDto.Add(_mapper.Map<UsuarioDto_cs>(lista));
            }
            return Ok(listaUsuariosDto);
        }

        [HttpGet("{usuarioId:int}", Name = "GetUsuario")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUsuario(int usuarioId)
        {
            var usuario = _usuarioRepositorio.GetUsuario(usuarioId);

            if (usuario == null)
            {
                return NotFound();
            }

            var usuarioDto = _mapper.Map<UsuarioDto_cs>(usuario);

            return Ok(usuarioDto);
        }

        [HttpPost]
        [ProducesResponseType(201, Type =  typeof(UsuarioDto_cs))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult PostUsuario([FromBody] CreateUsuarioDto_cs createUsuarioDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(createUsuarioDto == null)
            {
                return BadRequest(ModelState);
            }

            if(_usuarioRepositorio.ExistUsuario(createUsuarioDto.Email))
            {
                ModelState.AddModelError("","Usuario ya creado");
                return StatusCode(404, ModelState);
            }

            var usuario = _mapper.Map<Usuario>(createUsuarioDto);

            if (!_usuarioRepositorio.CreateUsuario(usuario))
            {
                ModelState.AddModelError("", "Error al registrar el usuario");
                return StatusCode(500, ModelState);
            }
            return CreatedAtRoute("GetUsuario", new { usuarioId = usuario.Id }, usuario);
        }
    }
}
