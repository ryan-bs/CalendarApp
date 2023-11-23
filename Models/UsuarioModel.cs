using Microsoft.AspNetCore.Identity;

namespace CalendarApp.Models
{
    public class UsuarioModel : IdentityUser
    {
        public virtual ICollection<EventoModel> Eventos { get; set; }
    }
}
