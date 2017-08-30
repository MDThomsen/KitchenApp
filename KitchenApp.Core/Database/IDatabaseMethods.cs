using System.Threading.Tasks;

namespace KitchenApp.Database
{
    interface IDatabaseMethods<T> where T : BaseItem
    {
        Task<T> GetById(string id);
    }
}
