var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Твой endpoint
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
        new { id = 10, name = "Julia", phone = "900-100-0010" },
        new { id = 11, name = "Kevin", phone = "900-100-0011" },
        new { id = 12, name = "Laura", phone = "900-100-0012" },
        new { id = 13, name = "Mike", phone = "900-100-0013" },
        new { id = 14, name = "Nina", phone = "900-100-0014" },
        new { id = 15, name = "Oscar", phone = "900-100-0015" },
        new { id = 16, name = "Paula", phone = "900-100-0016" },
        new { id = 17, name = "Quentin", phone = "900-100-0017" },
        new { id = 18, name = "Rachel", phone = "900-100-0018" },
        new { id = 19, name = "Steve", phone = "900-100-0019" },
        new { id = 20, name = "Tina", phone = "900-100-0020" }
    };

    var filtered = orders.Where(o => o.id < 10);

    return filtered;
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Run($"http://0.0.0.0:{port}");