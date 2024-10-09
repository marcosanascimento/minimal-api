using minimal_api.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá Pessoal !");

app.MapPost("/login",minimal_api.Dominio.DTOs.LoginDTOs) => {
    if (LoginDTO.Email == "adm@teste.com" && LoginDTO.Senha == "123456")
        return Results.Ok("Login com Sucesso");
    else
        return Results.Unauthorized;
)}

app.Run();
