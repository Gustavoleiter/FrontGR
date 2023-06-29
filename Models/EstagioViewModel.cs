using FrontGR.Models.Enuns;
using FrontGR.Models;

namespace FrontGR.Models
{
    public class EstagioViewModel
    {
        public int Id { get; set; }
        public string NomeEmpresa { get; set; } 
        public DateTime DataInicio { get; set; } 
        public DateTime DataTermino { get; set; } 
        public  TipoUrgenciaViewModel TipoUrgencia { get; set; }
         public List<UsuariosViewModel> Usuario { get; set; }
    }
}