// PropertyItemsController.cs in Controllers
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using RealEstate.Models;

namespace TodoApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoItemsController : ControllerBase
{
    private readonly ListingsContext _context;

    public TodoItemsController(ListingsContext context)
    {
        _context = context;
    }

    // GET: api/TodoItems
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ListingsItemDTO>>> GetTodoItems()
    {
        return await _context.ListingsItems

       .Select(x => ItemToDTO(x))
       .ToListAsync();
    }

    // GET: api/TodoItems/5
    // <snippet_GetByID>
    [HttpGet("{id}")]
    public async Task<ActionResult<ListingsItemDTO>> GetTodoItem(long id)
    {
        var ListingItem = await _context.ListingsItems.FindAsync(id);

        if (ListingItem == null)
        {
            return NotFound();
        }

        return ItemToDTO(ListingItem);
    }
    // </snippet_GetByID>

    // PUT: api/TodoItems/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // <snippet_Update>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTodoItem(long id, ListingsItemDTO listingDTO)
    {
        if (id != listingDTO.Id)
        {
            return BadRequest();
        }

        var ListingItem = await _context.ListingsItems.FindAsync(id);
        if (ListingItem == null)
        {
            return NotFound();
        }

        ListingItem.Name = listingDTO.Name;
        ListingItem.IsComplete = listingDTO.IsComplete;
        ListingItem.Worker = listingDTO.Worker;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!TodoItemExists(id))
        {
            return NotFound();
        }

        return NoContent();
    }
    // </snippet_Update>

    // POST: api/TodoItems
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // <snippet_Create>
    [HttpPost]
    public async Task<ActionResult<ListingsItemDTO>> PostTodoItem(ListingsItemDTO listingItemDTO)
    {
        var ListingItem = new ListingItems
        {
            IsComplete = listingItemDTO.IsComplete,
            Name = listingItemDTO.Name,
            Worker = listingItemDTO.Worker
        };

        _context.ListingsItems.Add(ListingItem);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetTodoItem),
            new { id = ListingItem.Id },
            ItemToDTO(ListingItem));
    }
    // </snippet_Create>

    // DELETE: api/TodoItems/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodoItem(long id)
    {
        var ListingItem = await _context.ListingsItems.FindAsync(id);
        if (ListingItem == null)
        {
            return NotFound();
        }

        _context.ListingsItems.Remove(ListingItem);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TodoItemExists(long id)
    {
        return _context.ListingsItems.Any(e => e.Id == id);
    }

    private static ListingsItemDTO ItemToDTO(ListingItems ListingItem) =>
       new ListingsItemDTO
       {
           Id = ListingItem.Id,
           Name = ListingItem.Name,
           IsComplete = ListingItem.IsComplete,
           Worker = ListingItem.Worker
       };
}