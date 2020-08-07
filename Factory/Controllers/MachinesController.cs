using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  { 
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
    }
    public ActionResult Details(int id)
    {
      var thisMachine = _db.Machines
        .Include(machine =>machine.Engineers)
        .ThenInclude(join => join.Machine)
        .FirstOrDefault(machine => machine.MachineId ==id);
      return View(thisMachine);
    }
  }
}