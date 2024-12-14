using API.BLL.DTO;
using API.BLL.Exceptions;
using API.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class OrderController(IOrderService _service) : ControllerBase
{
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var data = await _service.GetAllAsync();
            if (data != null)
            {
                return Ok(data);
            }
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        return NoContent();
    }
    [HttpGet("GetById")]

    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var data = await _service.GetAsync(id);
            if (data != null)
            {
                return Ok(data);
            }
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (Exception)
        {
            throw;
        }

        return NoContent();
    }
    [HttpGet("GetByBikeId")]
    public async Task<IActionResult> GetByBikeId(int bikeId)
    {
        try
        {
            return Ok(await _service.GetByBikeId(bikeId));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPost("add")]
    public async Task<IActionResult> Post(CreateOrderDTO model)
    {
        var data = await _service.AddAsync(model);
        return Ok(data);
    }
    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
    [HttpPut("Update")]
    public async Task<IActionResult> Update(int id, CreateOrderDTO DTO)
    {
        var data = await _service.UpdateByIdAsync(id, DTO);
        return Ok(data);
    }
}
