using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDto newRentalDto)
        {
            if (newRentalDto.MovieIds.Count == 0)
                return BadRequest("No Movie Ids have been given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRentalDto.CustomerId);

            if (customer == null)
                return BadRequest("Customer Id is not valid.");

            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

            if (newRentalDto.MovieIds.Count != movies.Count)
                return BadRequest("One or more Movie Ids are invalid.");

            foreach(var movie in movies)
            {
                if (movie.Availability == 0)
                    return BadRequest("Movie is not available.");

                movie.Availability--;

                var rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

    }
}