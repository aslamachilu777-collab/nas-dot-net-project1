using Microsoft.AspNetCore.Mvc;
using nas_project1.Model;
using nas_project1.Data;
using Microsoft.EntityFrameworkCore;
using System;


namespace nas_project1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoliciesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PoliciesController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/policies
        [HttpPost]
        public IActionResult Create(Policy policy)
        {
            // Add the new policy into the database
            _context.Policies.Add(policy);

            // Save changes into the database
            _context.SaveChanges();

            // Return the policy as response
            return Ok(policy);
        }

        // GET: api/policies
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var policy = await _context.Policies.FindAsync(id);

            if (policy == null)
            {
                return NotFound($"Policy with ID {id} not found.");
            }

            return Ok(policy);
        }
    }
}
