using ETreeks.Core.Data;
using ETreeks.Core.DTO;
using ETreeks.Core.IService;
using ETreeks.Infra.Service;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETreeks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }


        [HttpPost("create")]
        public async Task<IActionResult> CreateAddress([FromBody] AddresssDto addressDto )
        {

            var result = await _addressService.CreateAddress(addressDto );
            return Ok(result);
        }


      

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateAddress(int id, [FromBody] AddresssDto addressDto)
        {

            addressDto.Id = id;
            var result = await _addressService.UpdateAddress(addressDto);
            return Ok(result);


        }

     




        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var result = await _addressService.DeleteAddress(id);
            return Ok(result);



        }



     

        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<AddressDto>>> GetAllAddresses()
        {
            var addresses = await _addressService.GetAllAddresses();
            return Ok(addresses);
        }

    


        [HttpGet("get/{id}")]
        public async Task<ActionResult<AddressDto>> GetAddressById(int id)
        {
            var address = await _addressService.GetAddressById(id);
            return Ok(address);
        }
    }
}
