using System.Linq;

namespace MerciSoftware.Middleware
{
    public class AutenticazioneMiddleware
    {
        private readonly RequestDelegate _next;

        public AutenticazioneMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var percorsiProtetti = new[]
            {
                "/Home/Controlli",
                "/Home/Passeggeri",
                "/Home/Merci",
                "/Home/Segnalazioni"
            };

            bool isAuthenticated = context.Session.GetString("FunzionarioLoggato") != null;

            if (!isAuthenticated && percorsiProtetti.Any(p => context.Request.Path.StartsWithSegments(p)))
            {
                context.Response.Redirect("/login");
                return;
            }

            await _next(context);
        }
    }
}
