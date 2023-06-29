
using FrontGR.Models.Enuns;
using FrontGR.Models;

namespace FrontGR.Models
{
    public class FaculdadeViewModel
    {
        public int Id { get; set; }
        public string NomeFaculdade { get; set; } 
        public string Descrição { get; set; }
        public DateTime DataInicio { get; set; } 
        public DateTime DataTermino { get; set; } 
        public TipoUrgenciaViewModel TipoUrgencia { get; set; }
        public List<UsuariosViewModel> Usuario { get; set; }
    }
}