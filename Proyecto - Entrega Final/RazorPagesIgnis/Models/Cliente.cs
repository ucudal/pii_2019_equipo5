using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using RazorPagesIgnis.Areas.Identity.Data;

namespace RazorPagesIgnis
{ 
    /// <summary>
    /// Cliente del Centro Ignis.
    /// El cliente tiene proyectos y contrata técnicos.
    /// </summary>
    public class Cliente : ApplicationUser
    { 
        /// <summary>
        /// RazorPages: constructor sin argumentos.
        /// </summary>
        public Cliente() : base () {}

        // /// <summary>
        // /// RazorPages: atributo PrimaryKey.
        // /// </summary>
        // [Key]
        // public int Id { get; set; }  

        // Relación Cliente:Proyectos (uno-a-muchos)
        public IList<Proyecto> Proyectos { get; set; }

    }
}
