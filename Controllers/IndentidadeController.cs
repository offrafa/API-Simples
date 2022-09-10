using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndentidadeController : ControllerBase
    {
        public IEnumerable<IndentidadeModel> indentidades = new IndentidadeModel[]
        {
            new IndentidadeModel()
            {
                Id = 1,
                Nome = "Thiago",
                SobreNome = "Silva",
                PaisDeOrigem = "Brasil",
                Cpf = "123.456.678-98",
                DataDeNacimento = "23/09/1994",
                CodigoDoPais = "+55",
                Telefone = "953134647"
            },
            new IndentidadeModel()
            {
                Id = 2,
                Nome = "Maria",
                SobreNome = "Solza",
                PaisDeOrigem = "Brasil",
                Cpf = "345.246.567-26",
                DataDeNacimento = "23/09/1980",
                CodigoDoPais = "+55",
                Telefone = "989753685"
            },
            new IndentidadeModel()
            {
                Id = 3,
                Nome = "Fernanda",
                SobreNome = "Silva",
                PaisDeOrigem = "austrália",
                Cpf = "456.324.786-09",
                DataDeNacimento = "23/09/1990",
                CodigoDoPais = "+61",
                Telefone = "9235846783"
            },
            new IndentidadeModel()
            {
                Id = 4,
                Nome = "Bianca",
                SobreNome = "Silva",
                PaisDeOrigem = "Alemanha",
                Cpf = "865.213.754-19",
                DataDeNacimento = "23/09/1994",
                CodigoDoPais = "+49",
                Telefone = "9125734567"
            },
            new IndentidadeModel()
            {
                Id = 5,
                Nome = "Thiago",
                SobreNome = "Oliveira",
                PaisDeOrigem = "Brasil",
                Cpf = "566.256.235-45",
                DataDeNacimento = "23/09/2000",
                CodigoDoPais = "+55",
                Telefone = "953134647"
            }
        };

        [HttpGet]
        public IEnumerable<IndentidadeModel> Get()
        {
            return indentidades;
        }
        [HttpGet("{id}")]
        public IEnumerable<IndentidadeModel> GetById(int id)
        {
            return indentidades.Where(Indentidade => Indentidade.Id == id);
        }
        
    }
}
