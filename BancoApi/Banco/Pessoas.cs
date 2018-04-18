namespace BancoApi.Banco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pessoas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Pessoa { get; set; }

        [StringLength(50)]
        public string Nome_Pessoa { get; set; }

        [StringLength(50)]
        public string Email_Pessoa { get; set; }
    }
}
