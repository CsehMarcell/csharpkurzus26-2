using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

using Microsoft.Extensions.Logging;

namespace Calculator.Htpp;

public class HttpServer : IDisposable
{
    private readonly int _port;
    private readonly ILogger<HttpServer> _logger;
    private readonly TcpListener _server;
    private readonly SemaphoreSlim _semaphore;
    private bool _disposed;

    public HttpServer(int port, ILoggerFactory loggerFactory)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(port, 1000);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(port, ushort.MaxValue);

        _port = port;
        _logger = loggerFactory.CreateLogger<HttpServer>();
        _server = new TcpListener(IPAddress.Any, _port);
        _semaphore = new SemaphoreSlim(10);
    }
    
    ~HttpServer()
    {
        Dispose(false);
    }

    protected virtual void Dispose(bool isDirectCall)
    {
        _server.Dispose();
        _semaphore.Dispose();
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public void Start()
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(HttpServer));

        _logger.LogInformation("Starting http server on port {port}", _port);


    }
}
