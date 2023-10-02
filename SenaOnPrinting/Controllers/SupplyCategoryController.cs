﻿using AutoMapper;
using BusinessCape.DTOs.SupplyCategory;
using BusinessCape.Services;
using DataCape.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SenaOnPrinting.Filters;
using SenaOnPrinting.Permissions;

namespace SenaOnPrinting.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    //[AuthorizationFilter(ApplicationPermission.Supply)]
    public class SupplyCategoryController : ControllerBase
    {
        private readonly SupplyCategoryService _supplyCategoryService;
        private readonly IMapper _mapper;

        public SupplyCategoryController(SupplyCategoryService supplyCategoryService, IMapper mapper)
        {
            _supplyCategoryService = supplyCategoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var supplyCategories = await _supplyCategoryService.GetAllAsync();
            return Ok(supplyCategories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var supplyCategory = await _supplyCategoryService.GetByIdAsync(id);
            if (supplyCategory == null)
            {
                return NotFound();
            }
            return Ok(supplyCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SupplyCategoryCreateDto supplyCategoryDto)
        {
            //var supplyToCreate = new SupplyCategoryModel();
            //supplyToCreate.Name = supplyCategoryDto.Name;
            //supplyToCreate.Description = supplyCategoryDto.Description;
            //supplyToCreate.StatedAt = true;
            var supplyToCreate = _mapper.Map<SupplyCategoryModel>(supplyCategoryDto);

            await _supplyCategoryService.AddAsync(supplyToCreate);
            return Ok(supplyToCreate);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, SupplyCategoryUpdateDto supplyCategoryDto)
        {
            if (id != supplyCategoryDto.Id)
            {
                return BadRequest();
            }

            var supplyToUpdate = await _supplyCategoryService.GetByIdAsync(supplyCategoryDto.Id);

            //supplyToUpdate.Name = supplyCategoryDto.Name;
            //supplyToUpdate.Description = supplyCategoryDto.Description;
            _mapper.Map(supplyCategoryDto, supplyToUpdate);

            await _supplyCategoryService.UpdateAsync(supplyToUpdate);
            return Ok(supplyToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _supplyCategoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}