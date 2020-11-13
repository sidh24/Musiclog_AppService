namespace Musiclog_App_Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Albumdetail")]
    public partial class Albumdetail
    {
        [Key]
        public int Albumid { get; set; }

        [StringLength(50)]
        public string AlbumName { get; set; }

        [StringLength(50)]
        public string Artist { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public int? Stock { get; set; }
    }
}
