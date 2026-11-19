using Calculator.Htpp;

using Microsoft.Extensions.Logging;

using ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

using var server = new HttpServer(8080, loggerFactory);

server.Start();

Console.ReadKey();

server.Stop();
