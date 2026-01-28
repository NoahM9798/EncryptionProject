using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enkel krypteringslogik (Caesar-chiffer med 3 steg)
string Transform(string input, int shift)
{
    return new string(input.Select(c => (char)(c + shift)).ToArray());
}

// Endpoint 1: Kryptera
app.MapGet("/encrypt", (string text) =>
{
    var encrypted = Transform(text, 3);
    return Results.Ok(new { original = text, result = encrypted, method = "Caesar-3" });
});

// Endpoint 2: Avkryptera
app.MapGet("/decrypt", (string text) =>
{
    var decrypted = Transform(text, -3);
    return Results.Ok(new { original = text, result = decrypted, method = "Caesar-3" });
});

app.Run();