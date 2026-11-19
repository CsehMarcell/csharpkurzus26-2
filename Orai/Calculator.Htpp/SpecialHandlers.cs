using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Calculator.Htpp;

internal static class SpecialHandlers
{
    internal static async Task HandleNotFound(NetworkStream stream)
    {
        string message = "<img src='https://http.cat/404'>";

        string response = $"""
            HTTP/1.1 404 Not Found
            Date: {DateTime.UtcNow:R}
            Content-Type: text/html; charset=utf-8
            Content-Length: {Encoding.UTF8.GetByteCount(message)}

            {message}
            """;

        var encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

        using StreamWriter writer = new StreamWriter(stream, encoding, leaveOpen: true);

        await writer.WriteAsync(response);
    }

    internal static async Task HandleServerError(NetworkStream stream, Exception ex)
    {
        string message = "<img src='https://http.cat/500'>";

        string response = $"""
            HTTP/1.1 500 Internal server error
            Date: {DateTime.UtcNow:R}
            Content-Type: text/html; charset=utf-8
            Content-Length: {Encoding.UTF8.GetByteCount(message)}

            {message}
            """;

        var encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

        using StreamWriter writer = new StreamWriter(stream, encoding, leaveOpen: true);

        await writer.WriteAsync(response);
    }
}
