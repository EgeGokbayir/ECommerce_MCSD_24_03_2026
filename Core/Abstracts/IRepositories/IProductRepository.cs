using Core.Concretes.Entities;
using Utils.Generics;

namespace Core.Abstracts.IRepositories
{
    public interface IProductRepository : IRepository<Product> { }
    public interface ICategoryRepository : IRepository<Category> { }
    public interface ISubcategoryRepository : IRepository<Subcategory> { }
    public interface IBrandRepository : IRepository<Brand> { }
    public interface IProductImageRepository : IRepository<ProductImage> { }
    public interface IProductAttributeRepository : IRepository<ProductAttribute> { }
    public interface IProductReviewRepository : IRepository<ProductReview> { }
    public interface ICartRepository : IRepository<Cart> { }
    public interface ICartItemRepository : IRepository<CartItem> { }
}
