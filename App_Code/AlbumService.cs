using System.Collections.Generic;

namespace Musiclog_App_Service

{
    public class AlbumService : IAlbumService
    {
        AlbumEntities tstDb = new AlbumEntities();
        public List<Albumdetail> GetAlbumdetails()
        {
            List<Albumdetail> albumList = new List<Albumdetail>();
            var movieListResult = from k in tstDb.Albumdetail select k;
            foreach (var item in movieListResult)
            {
                Albumdetail mv = new Albumdetail();
                mv.AlbumId = item.AlbumId;
                mv.AlbumName = item.AlbumName;
                mv.Artist = item.Artist;
                mv.Type = item.Type;
                mv.Stock = item.Stock;
                albumList.Add(mv);
            }

            return albumList;
        }

        public int DeleteAlbumdetailById(int Id)
        {

            Albumdetail mvd = new Albumdetail();
            mvd.AlbumId = Id;
            tstDb.Entry(mvd).State = System.Data.Entity.EntityState.Deleted
            int Retval = tstDb.SaveChanges();
            return Retval;
        }

        public int AddAlbum(int AlbumId, string AlbumName, string Artist, string Type, int stock)
        {

            Albumdetail mvd = new Albumdetail();
            mvd.AlbumId = AlbumId;
            mvd.AlbumName = AlbumName;
            mvd.Artist = Artist;
            mvd.Type = Type;
            mvd.Stock = stock;
            tstDb.Albumdetail.Add(mvd);
            int Retval = tstDb.SaveChanges();
            return Retval;
        }

        public Albumdetail GetAllAlbumById(int AlbumId)
        {
            var albumListResult = from k in tstDb.movies where k.Id == AlbumId select k;
            Albumdetail mv = new Albumdetail();
            foreach (var item in albumListResult)
            {
                mv.AlbumId = item.AlbumId;
                mv.AlbumName = item.AlbumName;
                mv.Artist = item.Artist;
                mv.Type = item.Type;
                mv.Stock = item.stock;
            }

            return mv;
        }

        public int UpdateAlbum(int AlbumId, string AlbumName, string Artist, string Type, int stock)
        {

            Albumdetail mvd = new Albumdetail();
            mvd.AlbumId = AlbumId;
            mvd.AlbumName = AlbumName;
            mvd.Artist = Artist;
            mvd.Type = Type;
            mvd.Stock = stock;
            tstDb.Entry(mvd).State = System.Data.Entity.EntityState.Modified;

            int Retval = tstDb.SaveChanges();
            return Retval;
        }

        public int DeleteAlbumById(int AlbumId)
        {
            Albumdetail mvd = new Albumdetail();
            mvd.AlbumId = AlbumId;
            tstDb.Entry(mvd).State = System.Data.Entity.EntityState.Deleted;
            int Retval = tstDb.SaveChanges();
            return Retval;
        }
    }
}
