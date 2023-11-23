namespace CalendarApp.Models
{
    public class EventoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        #region [ChaveEstrangeira]
        public virtual UsuarioModel UserModel { get; set; }
        #endregion

        public EventoModel()
        {
            UserModel = new UsuarioModel();
        }
    }
}
