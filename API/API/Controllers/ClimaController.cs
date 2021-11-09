using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClimaController : ControllerBase
    {
        private static readonly string[] Resumenes = new[]
        {
            "Soleado", "Nublado", "Lluvioso"
        };

        private readonly ILogger<ClimaController> _logger;

        public ClimaController(ILogger<ClimaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Clima> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 3).Select(index => new Clima(
                DateTime.Now.AddDays(index),
                rng.Next(-20, 55),
                rng.Next(0, 55),
                Resumenes[rng.Next(Resumenes.Length)])).ToArray();
        }
    }
}
