using APIMiniProject.Models;

namespace APIMiniProject.Interfaces
{
    public interface IGifsAPIService
    {
        Task<List<GifModel>> GetGifs();
    }
}
