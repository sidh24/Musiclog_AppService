namespace
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AlbumModel : DbContext
    {
        public AlbumModel()
            : base("name=AlbumEntities")
        {
        }

        public virtual DbSet<Albumdetail> Albumdetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
