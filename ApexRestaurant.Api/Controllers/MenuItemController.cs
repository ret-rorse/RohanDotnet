using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenuItem;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller {
    [Route ("api/menuitem")]
    public class MenuItemController : ControllerBase {
        private readonly IMenuItemService _menuItemService;
        public MenuItemController (IMenuItemService menuItemService) {
            _menuItemService = menuItemService;
        }

        [HttpGet]
        [Route ("{id}")]
        public IActionResult Get ([FromRoute] int id) {
            var menuItem = _menuItemService.GetById (id);
            if (menuItem == null)
                return NotFound ();
            return Ok (menuItem);
        }

        [HttpGet]
        [Route ("")]
        public IActionResult GetAll () {
            var menuItems = _menuItemService.GetAll ();
            return Ok (menuItems);
        }

        [HttpPost]
        [Route ("")]
        public IActionResult Post ([FromBody] MenuItem model) {
            _menuItemService.Insert (model);
            return Ok ();
        }

        [HttpPut]
        [Route ("")]
        public IActionResult Put ([FromBody] MenuItem model) {
            _menuItemService.Update (model);
            return Ok ();
        }

        [HttpDelete]
        [Route ("")]
        public IActionResult Delete ([FromBody] int id) {
            _menuItemService.Delete (id);
            return Ok ();
        }
    }
}