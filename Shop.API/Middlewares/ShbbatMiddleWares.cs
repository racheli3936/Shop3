namespace Shop.API.Middlewares
{
    public class ShbbatMiddleWares
    {
        private readonly RequestDelegate _next;
        public ShbbatMiddleWares(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            string d = DateTime.Now.DayOfWeek.ToString();
            if (d == "Saturday")
            {
                Console.WriteLine("we close in Saturday");
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            await _next(context);

        }
    }
}
