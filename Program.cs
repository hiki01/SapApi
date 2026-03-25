var builder = WebApplication.CreateBuilder(args);

// ВАЖНО — тут настраиваем URL
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
// builder.WebHost.UseUrls($"http://0.0.0.0:{port}");
builder.WebHost.UseUrls($"http://0.0.0.0:5000");

var app = builder.Build();

// endpoint
app.MapGet("/orders", () =>
{
    var orders = new[]
    {
        new { id = 1, name = "Alice", phone = "900-100-0001" },
        new { id = 2, name = "Bob", phone = "900-100-0002" },
        new { id = 3, name = "Charlie", phone = "900-100-0003" },
        new { id = 4, name = "Diana", phone = "900-100-0004" },
        new { id = 5, name = "Ethan", phone = "900-100-0005" },
        new { id = 6, name = "Fiona", phone = "900-100-0006" },
        new { id = 7, name = "George", phone = "900-100-0007" },
        new { id = 8, name = "Hannah", phone = "900-100-0008" },
        new { id = 9, name = "Ian", phone = "900-100-0009" },
        new { id = 10, name = "Julia", phone = "900-100-0010" }
    };

    return orders.Where(o => o.id < 10);
});

app.Run();