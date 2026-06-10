using Microsoft.AspNetCore.Mvc;
using Grocery_list_api.Models;
using Grocery_list_api.Data;
namespace Grocery_list_api.Controllers
{
    [ApiController]
    [Route("grocery_list")]
    public class GroceryListController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var items = GroceryStorage.Load();
            return Ok(items);
        }

        [HttpPost]
        public IActionResult Add(GroceryItem item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
                return BadRequest("Le nom ne peut pas être vide.");

            if (item.Quantity < 1)
                return BadRequest("La doit quantité doit être plus grande ou égale à 1.");

            if (item.UnitPrice <= 0)
                return BadRequest("Le prix unitaire ne doit pas être nul.");

            var items = GroceryStorage.Load();

            item.Id = Guid.NewGuid();
            items.Add(item);

            GroceryStorage.Save(items);

            return Ok(item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, GroceryItem updatedItem)
        {
            var items = GroceryStorage.Load();

            var item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return NotFound();

            if (string.IsNullOrWhiteSpace(updatedItem.Name) ||
                updatedItem.Quantity < 1 ||
                updatedItem.UnitPrice <= 0)
                return BadRequest("Invalid data");

            item.Name = updatedItem.Name;
            item.Quantity = updatedItem.Quantity;
            item.UnitPrice = updatedItem.UnitPrice;

            GroceryStorage.Save(items);

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var items = GroceryStorage.Load();

            var item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return NotFound();

            items.Remove(item);

            GroceryStorage.Save(items);

            return Ok();
        }
    }
}
