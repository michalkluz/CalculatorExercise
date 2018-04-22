using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorExercise.Startup))]
namespace CalculatorExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
