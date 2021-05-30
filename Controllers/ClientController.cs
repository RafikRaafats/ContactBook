using AutoMapper;
using ContactBook.BL.Repository;
using ContactBook.DAL.Entity;
using ContactBook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRep cli;
        private readonly IMapper mapper;

        public ClientController(IClientRep cli , IMapper _Mapper)
        {
            this.cli = cli;
            mapper = _Mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = cli.GetAll();
            var res = mapper.Map<IEnumerable<ClientVM>>(data);
            return Ok(res);
        }


        [HttpPost]
        public IActionResult Add(Client obj)
        {
            //var data = mapper.Map<Client>(obj);
            //cli.AddObj(data);
            //return Ok(data);

            var data = cli.AddObj(obj);
            return Ok(data);

        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var data = cli.GetById(Id);
            return Ok(data);

        }

        [HttpPut]
        public IActionResult UpdateData(Client obj)
        {
            var data = cli.EditObj(obj);
            return Ok(data);

        }

        [HttpDelete]
        public IActionResult DeleteData(int Id)
        {
            var data = cli.DeleteObj(Id);
            return Ok(data);

        }




    }
}
