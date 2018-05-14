using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiModeloMVC.Models;

namespace MiModeloMVC.Controllers
{
    public class ClientesController : Controller
    {
        // Clientes
        public static List<Clientes> collectionClientes = new List<Clientes> {
            new Clientes {
                ID = 1,
                nombre = "Angel",
                fechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                edad = 30
            },
            new Clientes {
                ID = 2,
                nombre = "Juan",
                fechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                edad = 25
            },
            new Clientes {
                ID = 3,
                nombre = "Mariela",
                fechaAlta = DateTime.Parse(DateTime.Today.ToString()),
                edad = 18
            },
        };

        // GET: Clientes
        private EmpDBContext db = new EmpDBContext();
        public ActionResult Index()
        {
            var Clientes = from e in db.Clientes
                            orderby e.ID
                            select e;
            
            return View(Clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var Cliente = (from e in db.Clientes
                            where (int)e.ID == id
                            select e).First();
            return View(Cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Clientes newClient)
        {
            try
            {   
                db.Clientes.Add(newClient);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            /* var Cliente = (from e in collectionClientes
                            where (int)e.ID == id
                            select e).First(); */
            var Cliente = db.Clientes.Single(m=>m.ID == id);
            return View(Cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var Cliente = db.Clientes.Single(m=>m.ID == id);                
                if (await TryUpdateModelAsync<Clientes>(Cliente)) {
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(Cliente);
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var Cliente = (from e in db.Clientes
                            where (int)e.ID == id
                            select e).First();
            return View(Cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Listados de Clientes
        [NonAction]
        public List<Clientes> ListClients() {
            return collectionClientes;
        }

    }
}