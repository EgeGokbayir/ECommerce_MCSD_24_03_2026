using Core.Concretes.DTOs;
using Utils.Responses;

namespace Core.Abstracts.IServices
{
    public interface IShowroomService
    {
        Task<IResult<IEnumerable<ProductListItemDto>>> GetProductAsync();
    }
}
