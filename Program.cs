using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(
    @"<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Hello from App 1</title>
    <style>
        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
        }

        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f9f9f9;
            color: #333;
            min-height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 20px;
        }

        .container {
            background-color: #ffffff;
            padding: 30px;
            border: 1px solid #e0e0e0;
            border-radius: 8px;
            text-align: center;
            max-width: 500px;
            width: 100%;
            box-shadow: 0 2px 8px rgba(0, 0, 0, 0.05);
        }

        h1 {
            font-size: 1.75rem;
            margin-bottom: 10px;
            color: #111;
        }

        p {
            font-size: 1rem;
            margin: 10px 0;
        }

        .price {
            font-size: 1.25rem;
            font-weight: 600;
            color: #007acc;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <div class='container'>
        <h1>Hello from App Service!</h1>
        <p>This is the HelloWorldApp deployed using .NET 8.</p>
        <p>Solana is a high-performance blockchain supporting fast and low-cost transactions. It is widely used for decentralized applications and crypto projects.</p>
        <p class='price'>Price of Solana: $20.50</p>
    </div>
</body>
</html>",
"text/html"));

app.Run();
