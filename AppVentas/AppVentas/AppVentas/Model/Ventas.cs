using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppVentas.Model
{
    [Table("Listado")]
    public class Ventas
    {
        [PrimaryKey, AutoIncrement]
        public int VentaId { get; set; }
        [MaxLength(70)]
        public string Producto { get; set; }
        [NotNull]
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }


    }
}
