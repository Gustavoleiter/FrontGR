using FrontGR.Models;
namespace FrontGR.Models
{
    public class UsuariosViewModel
    {
         public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordString { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public DateTime? DataAcesso { get; set; }
        public List<CursoViewModel> Cursos { get; set; }
        public List<FaculdadeViewModel> Faculdades { get; set; }
        public List<EstagioViewModel> Estagios { get; set; }
    }
}