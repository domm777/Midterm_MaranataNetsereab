using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MidtermAPI_MaranataNetsereab.Data;
using MidtermAPI_MaranataNetsereab.Model;
using MidtermAPI_MaranataNetsereab.Repository;

namespace MidtermAPI_MaranataNetsereab.Controllers {
    [Route("api/MNProduct")]
    [ApiController]
    public class MNProductController : ControllerBase {
        private readonly MNIProductService _service;
        public Dictionary<string, int> _requestCounts;

        [HttpGet]
        public IActionResult GetAllMNProductById() {
            var products = _service.GetByProductId();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult AddNewMNProduct([FromBody] MNProduct product) {
            if (product.Id <= 0) {
                return BadRequest(new {
                    error = "InvalidParameter",
                    message = "Id must be greater than zero."
                });
            }
            // if the description is null or empty, return a 400 Bad Request with a custom error message
            if (string.IsNullOrWhiteSpace(product.Name)) {
                return BadRequest(new {
                    error = "InvalidParameter",
                    message = "Name must not be empty."
                });
            }
            // if the cost is negative, return a 400 Bad Request with a custom error message
            if (product.Quantity < 0) {
                return BadRequest(new {
                    error = "InvalidParameter",
                    message = "Cost cannot be negative."
                });
            }

            var created = _service.AddProduct(product);

            return CreatedAtAction(
                nameof(GetAllMNProductById),
                new { id = created.Id },
                new {
                    message = "Product created",
                    Product = created
                }
            );
        }

        [HttpGet("usage")]
        public IActionResult Usage() {
            var key = Request.Headers["X-Api-Key"].ToString();

            if (!_requestCounts.ContainsKey(key))
                _requestCounts[key] = 0;

            _requestCounts[key]++;

            return Ok(new {
                clientId = key,
                callCount = _requestCounts[key]
            });
        }
    }
}
