using DeezerApp.Service.Domain;

namespace DeezerApp.Service.Service
{
    public interface IService
    {
        ServiceResponse GetSongs(string artistName);
    }
}
