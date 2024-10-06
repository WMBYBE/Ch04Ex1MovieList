using Ch04Ex1MovieList.Models;
using Microsoft.EntityFrameworkCore;

namespace Ch04Ex1MovieList
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MovieContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MovieContext")));
        }
    }
}
