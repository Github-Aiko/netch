#nullable disable
 namespace Netch.Servers;

 public class HysteriaConfig
 {
     /// <summary>
     /// </summary>
     public string server { get; set; }

     /// <summary>
     /// </summary>
     public string protocol { get; set; }

     /// <summary>
     /// </summary>
     public string obfs { get; set; }

     /// <summary>
     /// QUIC TLS ALPN
     /// </summary>
     public string alpn { get; set; }

     /// <summary>
     /// </summary>
     public string auth { get; set; }

     /// <summary>
     /// </summary>
     public string auth_str { get; set; }

     /// <summary>
     /// </summary>
     public string server_name { get; set; }

     /// <summary>
     /// </summary>
     public bool insecure { get; set; }

     /// <summary>
     /// </summary>
     public int up_mbps { get; set; }

     /// <summary>
     /// </summary>
     public int down_mbps { get; set; }

     /// <summary>
     /// </summary>
     public int recv_window_conn { get; set; }

     /// <summary>
     /// </summary>
     public int recv_window { get; set; }

     /// <summary>
     /// </summary>
     public Socks5Config socks5 { get; set; }

     /// <summary>
     /// </summary>
     public bool disable_mtu_discovery { get; set; }
 }

 public class Socks5Config
 {
     /// <summary>
     /// </summary>
     public string listen { get; set; }
 }