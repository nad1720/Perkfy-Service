using Microsoft.AspNetCore.Mvc;
using Perkfy.Application;
using Perkfy.DTO;
using Perkfy.DTO.Enums;
using System.Collections.Generic;

namespace Perkfy.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrandController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAllBrands")]
        public IActionResult GetAllBrands()
        {
            var brands = _unitOfWork.Brands.GetAll();
            return Ok(brands);
        }

        [HttpGet("GetBrandById/{id}")]
        public IActionResult GetBrandById(int id)
        {
            var brand = _unitOfWork.Brands.GetById(id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }

        [HttpPost("AddBrand")]
        public IActionResult AddBrand(BrandDTO brandDto)
        {
            _unitOfWork.Brands.Add(brandDto);
            _unitOfWork.Commit();
            return CreatedAtAction(nameof(GetBrandById), new { id = brandDto.Id }, brandDto);
        }

        [HttpPut("UpdateBrand/{id}")]
        public IActionResult UpdateBrand(int id, BrandDTO brandDto)
        {
            var existingBrand = _unitOfWork.Brands.GetById(id);
            if (existingBrand == null)
            {
                return NotFound();
            }

            _unitOfWork.Brands.Edit(id, brandDto);
            _unitOfWork.Commit();
            return NoContent();
        }

        [HttpPut("ChangeBrandStatus/status/{id}")]
        public IActionResult ChangeBrandStatus(int id, [FromBody] StatusEnum status)
        {
            var existingBrand = _unitOfWork.Brands.GetById(id);
            if (existingBrand == null)
            {
                return NotFound();
            }

            _unitOfWork.Brands.ChangeStatus(id, status);
            _unitOfWork.Commit();
            return NoContent();
        }
        [HttpGet("GetPaged")]
        public IActionResult GetPaged(int pageNumber, int pageSize, string sortColumn, string search, SortDirectionEnum sortDirection)
        {
            var brands = _unitOfWork.Brands.GetPaged(pageNumber, pageSize, sortColumn, search, sortDirection);
            return Ok(brands);
        }
    }
}
