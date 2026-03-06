using Microsoft.AspNetCore.Mvc;
using Prueba22.WEB.Data;
using Prueba22.WEB.Models;

namespace Prueba22.WEB.Controllers
{
    public class TareasController : Controller
    {

        private readonly DataContext _dataContext;
        public TareasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            var tareas = _dataContext.Tareas.Where(x=> !x.Estatus).ToList();
            return View(tareas);
        }

        [HttpGet]
        public IActionResult Nuevo()
        {
            var tarea = new TareaEntity();

            tarea.FechaTerminacion = DateTime.Now;
            return View(tarea);
        }
        [HttpPost]
        public IActionResult Nuevo(TareaEntity newObj)
        {
            newObj.FechaElaboracion = DateTime.Now;

            _dataContext.Tareas.Add(newObj);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Borrar(int id)
        {
            var tarea = _dataContext.Tareas.Where(x => x.Id == id).FirstOrDefault();
            // select * from Tareas where id=1

            _dataContext.Tareas.Remove(tarea);
            //delete from tareas whete id=1
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Modificar(int id)
        {
            var tarea=_dataContext.Tareas.Where(x=> x.Id== id).FirstOrDefault();
            return View(tarea);
        }

        [HttpPost]
        public IActionResult Modificar(TareaEntity obj)
        {
            var _tarea= _dataContext.Tareas.Where(x=> x.Id== obj.Id).FirstOrDefault();
 
            _tarea.Tarea= obj.Tarea;
            _tarea.Descripcion = obj.Descripcion;
            _tarea.FechaTerminacion= obj.FechaTerminacion;

            _dataContext.Tareas.Update(_tarea);
            _dataContext.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult TerminarTarea(int id)
        {
            var tarea = _dataContext.Tareas.Where(x => x.Id == id).FirstOrDefault();

            tarea.Estatus = true;

            _dataContext.Tareas.Update(tarea);
            _dataContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
