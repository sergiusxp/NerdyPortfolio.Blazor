using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace Blazor.Resume.Services
{
    public class ResumeService
    {
        public Models.Resume GetResume()
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "config", "portfolio.json");
            var json = System.IO.File.ReadAllText(file);
            return JsonConvert.DeserializeObject<Models.Resume>(json);
        }
    }
}
