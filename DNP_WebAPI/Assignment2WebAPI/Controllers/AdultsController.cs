using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Assignment2WebAPI.Data;
using Assignment2WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2WebAPI.Controllers
{
    [ApiController]
    [Route("/Adults")]
    public class AdultsController : ControllerBase
    {
        private IAdultsData adultsData;

        public AdultsController(IAdultsData  adultsData) {
            this.adultsData = adultsData;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> 
            GetAdults() {
            try {
                IList<Adult> adults = await adultsData.GetAdultsAsync();
                return Ok(adults);
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteAdult([FromRoute] int id) {
            try {
                await adultsData.RemoveAdultAsync(id);
                return Ok();
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try {
                Adult added = await adultsData.AddAdultAsync(adult);
                return Created($"/{added.Id}",added); // return newly added to-do, to get the auto generated id
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult) {
            try {
                Adult updatedAdult = await adultsData.UpdateAdultAsync(adult);
                return Ok(updatedAdult); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> 
            GetAdult([FromRoute] int id) {
            try {
                Adult adult = await adultsData.Get(id);
                return Ok(adult);
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

    }
}