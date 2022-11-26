using Netch.Models;

 namespace Netch.Servers;

 public class HysteriaServer : Server
 {
     public override string Type { get; } = "Hysteria";

     public override string MaskedData()
     {
         return "";
     }

     /// <summary>
     /// </summary>
     public string Protocol { get; set; } = "udp";

     /// <summary>
     /// </summary>
     public string OBFS { get; set; } = string.Empty;

     /// <summary>
     /// QUIC TLS ALPN
     /// </summary>
     public string ALPN { get; set; } = "h3";

     /// <summary>
     /// </summary>
     public string AuthType { get; set; } = "DISABLED";

     /// <summary>
     /// </summary>
     public string AuthPayload { get; set; } = string.Empty;

     /// <summary>
     /// </summary>
     public string ServerName { get; set; } = string.Empty;

     /// <summary>
     /// </summary>
     public string Insecure { get; set; } = "false";

     /// <summary>
     /// </summary>
     public int UpMbps { get; set; } = 100;

     /// <summary>
     /// </summary>
     public int DownMbps { get; set; } = 100;

     /// <summary>
     /// </summary>
     public int RecvWindowConn { get; set; } = 15728640;

     /// <summary>
     /// </summary>
     public int RecvWindow { get; set; } = 67108864;

     /// <summary>
     /// </summary>
     public string DisableMTUDiscovery { get; set; } = "false";
 }

 public class HysteriaGlobal
 {
     public static readonly List<string> Protocol = new()
     {
         "udp",
         "wechat-video"
     };

     public static readonly List<string> Auth_Type = new()
     {
         "DISABLED",
         "BASE64",
         "STR"
     };

     public static readonly List<string> Insecure = new()
     {
         "true",
         "false"
     };

     public static readonly List<string> Disable_MTU_Discovery = new()
     {
         "true",
         "false"
     };
 }