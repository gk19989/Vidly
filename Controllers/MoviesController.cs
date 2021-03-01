﻿using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using System.Linq;
using Vidly.ViewModels;
using Vidly.Migrations;
using System;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            
            return View();
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel(movie)
            {

                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", viewModel);

            }
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.NumberInStocks = movie.NumberInStocks;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {

                Genres = genres
            };

            return View("MovieForm", viewModel);
        }
    }
}