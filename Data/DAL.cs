using CalendarApp.Interfaces;
using CalendarApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace CalendarApp.Data
{
    public class DAL : IDAL
    {
        private ApplicationDbContext _context;

        public DAL()
        {
            _context = new ApplicationDbContext();
        }

        #region [Create]
        public void CreateEvento(EventoModel evento) // Talvez usar IFormCollection
        {
            _context.EventoModels.Add(evento);
            _context.SaveChanges();
        }
        #endregion

        #region [Update]
        public void UpdateEvento(EventoModel evento) // Talvez usar IFormCollection
        {
            var existingEvento = _context.EventoModels.Find(evento.Id);

            if (existingEvento != null)
            {
                existingEvento.Nome = evento.Nome;
                existingEvento.Description = evento.Description;
                existingEvento.StartTime = evento.StartTime;
                existingEvento.EndTime = evento.EndTime;

                _context.SaveChanges();
            }
        }
        #endregion

        #region [Delete]
        public void DeleteEvento(int id)
        {
            var evento = _context.EventoModels.Find(id);
            _context.EventoModels.Remove(evento);
            _context.SaveChanges();
        }
        #endregion

        #region [Read]
        public EventoModel GetEvento(int id)
        {
            return _context.EventoModels.FirstOrDefault(x => x.Id == id);
        }

        public List<EventoModel> GetEventos()
        {
            return _context.EventoModels.ToList();
        }

        public List<EventoModel> GetMeusEventos(string userid)
        {
            return _context.EventoModels.Where(x => x.UserModel.Id == userid).ToList();
        }
        #endregion
    }
}
