var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Твой endpoint
app.MapGet("/orders", () =>
{
    var orders = new[]
    {
        new { DocNum = 1, DocTotal = 500 },
        new { DocNum = 2, DocTotal = 1500 },
        new { DocNum = 3, DocTotal = 2000 }
    };

    var filtered = orders.Where(o => o.DocTotal > 1000);

    return filtered;
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Run($"http://0.0.0.0:{port}");