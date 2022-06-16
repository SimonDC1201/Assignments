using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoDbContext _context;
        public ToDoController(ToDoDbContext context)
        {
            _context = context;
        }


        // GET: api/<ToDoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListItem>>> GetMenuItems()
        {
            return await _context.ListItems.ToListAsync();
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListItem>> GetListItem(int id)
        {
            var listItem = await _context.ListItems.FindAsync(id);

            if (listItem == null)
            {
                return NotFound();
            }

            return listItem;
        }

        // POST api/<ToDoController>
        [HttpPost]
        public async Task<ActionResult<ListItem>> PostListItem(ListItem listItem)
        {
            _context.ListItems.Add(listItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListItem", new { id = listItem.Id }, listItem);
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListItem(int id, ListItem listItem)
        {
            if (id != listItem.Id)
            {
                return BadRequest();
            }
            _context.Entry(listItem).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListItem(int id)
        {
            var listItem = await _context.ListItems.FindAsync(id);
            if (listItem == null)
            {
                return NotFound();
            }

            _context.ListItems.Remove(listItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool ListItemExists(int id)
        {
            return _context.ListItems.Any(e => e.Id == id);
        }
    }
}
