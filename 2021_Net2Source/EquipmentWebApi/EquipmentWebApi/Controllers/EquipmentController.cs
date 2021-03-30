using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EquipmentWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentWebApi.Controllers
{//Swagging
    [Route("api/[controller]")]
    [ApiController]//Httppost,httpget,httpupdate,httpdelete   -verbs
    public class EquipmentController : ControllerBase
    {
              public IRepoEqui _IRepoEqui { get; set; }
        public EquipmentController(IRepoEqui repoEqui)
        {
            _IRepoEqui = repoEqui;
        }
        [HttpPost]
        public IActionResult Create([FromBody] EquiModels model)
        {
            if (model == null)
                return BadRequest();
            _IRepoEqui.Add(model);
            return new ObjectResult("Success");
        }
        [HttpGet]
      //  [Route("GetEqui")]--use for Overloading methods
        public IActionResult GetEqui()
        {
            IEnumerable<EquiModels> equi = _IRepoEqui.GetAll();
            return Ok(equi);
        }
        //if you don't write the  [HttpGet("{id}", Name = "GetEquipment")] 
        //then your url type is http://localhost:58904/api/Equipment?EquipmentID=1 or http://localhost:58904/api/Equipment/1

         [HttpGet("{id}", Name = "GetEquipment")]
        public IActionResult GetEquipments(int id)
        {
            EquiModels equiModel = _IRepoEqui.Find(id);
            return Ok(equiModel);
        }
        [HttpPut("{id}")]
        public IActionResult put(int id, [FromBody] EquiModels equi)
        {
            equi.EquipmentID= id;
            _IRepoEqui.Update(equi);
            return Ok("Updated");
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            _IRepoEqui.Remove(id);
            return Ok("deleted");
        }

    }
}
