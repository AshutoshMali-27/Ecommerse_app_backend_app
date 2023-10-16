
using Ecommerse_app_backend_app.Modals;

namespace Ecommerse_app_backend_app.DataAccess
{
    public interface IDataAccess
    {
       List<ProductCategpry> GetProductCategories();
       
       ProductCategpry GetProductCategpry(int id);

        Offer GetOffer(int id);

        List<Product> GetProducts(string category,string subcategory,int count);

        Product GetProduct(int id);

        bool InsertUser(User user);

        string IsUserPresent(string email, string password);
    }
}
