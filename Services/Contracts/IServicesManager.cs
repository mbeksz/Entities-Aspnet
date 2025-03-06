namespace Services.Contracts
{
    public interface IServicesManager
    {
        IProductService ProductService { get; }
        ICategoryService CategoryService { get; }
    }
}
 