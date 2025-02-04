using System.Net;
using System.Net.Sockets;
using System.Text;

/*
// Resolución de nombres de dominio (url)
IPHostEntry ipHostInfo = await Dns.GetHostEntryAsync("deepseek.com");
IPAddress ipAddress = ipHostInfo.AddressList[0];
*/

// Acceso a la ip local a través del nombre de host
var hostName = Dns.GetHostName();
IPHostEntry localhost = await Dns.GetHostEntryAsync(hostName);
// This is the IP address of the local machine
IPAddress localIpAddress = localhost.AddressList[0];


IPEndPoint ipEndPoint = new(localIpAddress, 11_000);

using Socket listener = new(
    ipEndPoint.AddressFamily,
    SocketType.Stream,
    ProtocolType.Tcp);


listener.Bind(ipEndPoint);
listener.Listen(100);

// Para transmitir/recibir datos debemos codificar los caracteres
//var palNico = Encoding.UTF8.GetBytes("Ñ");

var handler = await listener.AcceptAsync();
while (true)
{
    // Receive message.
    var buffer = new byte[1_024];
    var received = await handler.ReceiveAsync(buffer, SocketFlags.None);
    var response = Encoding.UTF8.GetString(buffer, 0, received);
    
    var eom = "<|EOM|>";
    if (response.IndexOf(eom) > -1 ) // is end of message 
    {
        Console.WriteLine(
            $"Socket server received message: \"{response.Replace(eom, "")}\"");

        var ackMessage = "<|ACK|>";
        var echoBytes = Encoding.UTF8.GetBytes(ackMessage);
        await handler.SendAsync(echoBytes, 0);
        Console.WriteLine(
            $"Socket server sent acknowledgment: \"{ackMessage}\"");

        break;
    }
    // Sample output:
    //    Socket server received message: "Hi friends 👋!"
    //    Socket server sent acknowledgment: "<|ACK|>"
}
