using System.Collections.Generic;
using System.ServiceModel;

namespace Musiclog_App_Service
{
    [ServiceContract]
    public interface IAlbumService
    {
        [OperationContract]
        List<Albumdetail> GetAlbumdetails();

        [OperationContract]
        int AddAlbum(int AlbumId, string AlbumName, string Artist, string Type, int stock);

        [OperationContract]
        Albumdetail GetAllAlbumById(int AlbumId);
                    
        [OperationContract]
        int UpdateAlbum(int AlbumId, string AlbumName, string Artist, string Type, int stock);

        [OperationContract]
        int DeleteAlbumById(int AlbumId);

    }
}
