using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tools.Generator;
using System.Linq;

namespace DesignPatternsASPNET.Controllers
{
    public class GeneratorFileController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneratorConcreteBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork,
                                       GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GenerateFile(int typeFile)
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(x => x.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";
                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (typeFile == 1)
                    generatorDirector.CreateSimpleJsonGenerator(content, path);
                else
                    generatorDirector.CreateSimplePipeGenerator(content, path);

                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();

                return Json("Archivo Generado");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
