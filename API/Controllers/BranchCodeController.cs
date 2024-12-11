﻿using Application.Contracts.Services;
using Application.Models.DTOs.Group;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BranchCodeController : ControllerBase
    {
        private readonly IBranchCodeService _branchCodeService;
        public BranchCodeController(IBranchCodeService branchCodeService) 
        {
            _branchCodeService = branchCodeService;
        }
        [HttpGet("GetAllBranchCodes")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _branchCodeService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("GetBranchCodeById/{id}")]
        public async Task<ActionResult<GroupDTO>> GetById(string? id)
        {
            var response = await _branchCodeService.GetByIdAsync(id);
            return Ok(response);

        }
    }
}