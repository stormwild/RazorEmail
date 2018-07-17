using System.Threading.Tasks;

namespace RazorEmail.Lib.Services
{
    public interface IRazorRenderer
    {
         Task<string> RenderAsync<TModel>(string view, TModel model);
    }
}