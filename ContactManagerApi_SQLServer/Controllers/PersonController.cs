using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ContactManagerApi_SQLServer.DbOpr;
using ContactManagerApi_SQLServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ContactManagerApi_SQLServer.Controllers
{
    [ApiController]  
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPerson personService;
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger, IPerson personService)
        {
            _logger = logger;
            this.personService = personService;
        }

        [Route("listall")]
        public IActionResult  Index()
        {
            var personsList = personService.GetAllPerson();
            if (personsList.Count == 0)
                return NotFound();

            return Ok(personsList);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("edit")]        
        public IActionResult  Edit(Person person)
        {
            var result = personService.UpdatePerson(person);
            if (result == true)
                return Ok(person);
            else
                return BadRequest();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("delete")]           
        public IActionResult  Delete(Person person)
        {
            var result = personService.DeletePerson(person);
            if (result == true)
                return Ok(person);
            else
                return BadRequest();
        }

        [Route("details")]
        public IActionResult  Details(int Id)
        {
            var person = personService.GetPersons(Id);
            return Ok(person);
        }

        
        [Route("addseeddata")]
        public IActionResult InitializeSeedData()        
        {
            var result = personService.InitializeSeedData();
            return Ok(result);
        }
    }
}