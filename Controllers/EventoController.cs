using Microsoft.AspNetCore.Mvc;
using Proventos.API.Models;

namespace Proventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]
    {
          new Evento()
          {
            EventoId = 1,
            Tema = "Angular 11 e .NET 6",
            Local = "São Paulo",
            Lote = "1 Lote",
            QtdPessoas = 100,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
          },
          new Evento()
          {
            EventoId = 2,
            Tema = "JavaScript",
            Local = "São Paulo",
            Lote = "2 Lote",
            QtdPessoas = 150,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
          }
    };
 
    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
      
    }
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);

    }

}
