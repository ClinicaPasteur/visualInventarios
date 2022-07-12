using Inventarios_BE.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Inventarios_BE.Entidades
{
    public class Producto
    {
        [Key]
        public Int64 PRO_ID { get; set; }
        [Required(ErrorMessage = "El campo Marca es obligatorio")]
        [StringLength(maximumLength: 50)]
        [LetraCapital]
        public string PRO_MARCA { get; set; }
        [Required(ErrorMessage = "El campo Fecha es obligatorio")]
        public DateTime PRO_FECHA_INGRESO { get; set; }
        [Required(ErrorMessage = "El campo Modelo es obligatorio")]
        public string PRO_MODELO { get; set; }
        public string? PRO_SERIAL { get; set; }
        public string? PRO_COD_ACTIVO { get; set; }
        public string? PRO_CPU { get; set; }
        public string? PRO_GEN { get; set; } 
        public string? PRO_NUC { get; set; } 
        //public string PRO_RAM { get; set; } //DEFINIR TABLA PARA LA RAM
        //public int PRO_DISCO_DURO { get; set; }
        public string? PRO_ASIGNADO { get; set; } 
        public string? PRO_USO { get; set; } 
        public string? PRO_USER_WIN { get; set; } 
        public string? PRO_WIN_CON { get; set; }
        public string? PRO_NOMBRE_PRODUCTO { get; set; } 
        public string? PRO_DIRECCION_IP { get; set; } 
        public string? PRO_ANYDESK { get; set; }
        public string? PRO_CON_ANYDESK { get; set; }
        public string? PRO_SO { get; set; }
        public string? PRO_OFFICE { get; set; }
        public string? PRO_FILESERVER { get; set; }
        public bool PRO_ANTIVIRUS { get; set; }
    }
}
