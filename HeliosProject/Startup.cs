namespace HeliosProject
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context => context.Response.WriteAsync("YO"));
        }
    }
}