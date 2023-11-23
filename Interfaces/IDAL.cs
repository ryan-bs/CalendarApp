using CalendarApp.Models;

namespace CalendarApp.Interfaces
{
    public interface IDAL
    {
        public void CreateEvento(EventoModel evento);
        public void UpdateEvento(EventoModel evento);
        public void DeleteEvento(int id);
        public EventoModel GetEvento(int id);
        public List<EventoModel> GetEventos();
        public List<EventoModel> GetMeusEventos(string userid);
    }
}
