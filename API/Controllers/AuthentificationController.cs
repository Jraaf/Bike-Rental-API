﻿using API.BLL.DTO;
using API.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthentificationController(IUserService _service) : ControllerBase
{
    [HttpPost("register")]
    public async Task<ActionResult<UserDTO>> Register(CreateUserDTO dto)
    {
        return Ok(await _service.Register(dto));

    }
    [HttpPost("login")]
    public async Task<ActionResult<UserDTO>> Login(LoginUserDTO dto)
    {
        try
        {
            return Ok(await _service.Login(dto));
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }
}