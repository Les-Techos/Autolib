﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Autolib.Models.Domain;

namespace Autolib.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly autolibContext _context;

        public ReservationsController(autolibContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var autolibContext = _context.Reservation.Include(r => r.ClientNavigation).Include(r => r.VehiculeNavigation);
            return View(await autolibContext.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.ClientNavigation)
                .Include(r => r.VehiculeNavigation)
                .FirstOrDefaultAsync(m => m.Vehicule == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            ViewData["Client"] = new SelectList(_context.Client, "IdClient", "Login");
            ViewData["Vehicule"] = new SelectList(_context.Vehicule, "IdVehicule", "Disponibilite");
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Vehicule,Client,DateReservation,DateEcheance")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Client"] = new SelectList(_context.Client, "IdClient", "Login", reservation.Client);
            ViewData["Vehicule"] = new SelectList(_context.Vehicule, "IdVehicule", "Disponibilite", reservation.Vehicule);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["Client"] = new SelectList(_context.Client, "IdClient", "Login", reservation.Client);
            ViewData["Vehicule"] = new SelectList(_context.Vehicule, "IdVehicule", "Disponibilite", reservation.Vehicule);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Vehicule,Client,DateReservation,DateEcheance")] Reservation reservation)
        {
            if (id != reservation.Vehicule)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Vehicule))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Client"] = new SelectList(_context.Client, "IdClient", "Login", reservation.Client);
            ViewData["Vehicule"] = new SelectList(_context.Vehicule, "IdVehicule", "Disponibilite", reservation.Vehicule);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.ClientNavigation)
                .Include(r => r.VehiculeNavigation)
                .FirstOrDefaultAsync(m => m.Vehicule == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);
            _context.Reservation.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.Vehicule == id);
        }
    }
}