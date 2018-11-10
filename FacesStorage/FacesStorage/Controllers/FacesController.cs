using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacesStorage.Models;
using FacesStorage.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FacesStorage.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class FacesController : ControllerBase
    {
        private readonly IFaceServices _services;

        public FacesController(IFaceServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddPerson")]
        public ActionResult<PersonFaces> Add(PersonFaces faces)
        {
            var personFaces = _services.Add(faces);

            if (personFaces == null)
            {
                return NotFound();
            }
            return personFaces;
        }

        [HttpGet]
        [Route("GetPerson")]
        public ActionResult<Dictionary<string, PersonFaces>> Get()
        {
            var personFaces = _services.Get();

            if (personFaces.Count == 0)
            {
                return NotFound();
            }

            return personFaces;
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<string> Login(PersonFaces faces)
        {
            var answer = _services.Login(faces);
            return answer;
        }
    }
}