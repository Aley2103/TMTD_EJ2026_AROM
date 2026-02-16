using Microsoft.AspNetCore.Http;
using CapaEntidad;
using Microsoft.AspNetCore.Mvc;
using Web.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        [HttpGet]
        public List<PersonaCLS> listarPersona()
        {
            List<PersonaCLS> lista = new List<PersonaCLS>();
            using (Db41454Context bd = new Db41454Context())
            {
                lista = (from persona in bd.Personas
                         where persona.Bhabilitado == 1
                         select new PersonaCLS
                         {
                             iidpersona = persona.Iidpersona,
                             nombre = persona.Nombre,
                             appaterno = persona.Appaterno,
                             apmaterno = persona.Apmaterno,
                             fechanacimiento = persona.Fechanacimiento,
                             iidsexo = persona.Iidsexo.GetValueOrDefault(),
                             nombrecompleto = persona.Nombre + " " + persona.Appaterno + " " + persona.Apmaterno,
                             correo = persona.Correo,
                             fechanacimientocadena = persona.Fechanacimiento == null ? " "
                                 : persona.Fechanacimiento.Value.ToShortDateString()
                         }).ToList();
            }
            return lista;
        }

    }
}
