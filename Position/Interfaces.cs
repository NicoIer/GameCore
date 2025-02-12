using System;
using MagicOnion;
using MemoryPack;
using Network;

namespace GameCore.Position
{
    
    
    
    // /// <summary>
    // /// 给客户端用的
    // /// </summary>
    // public interface ICenterService : IService<ICenterService>
    // {
    //     public const string InternalRpcHost = "localhost";
    //     public const int InternalRpcPort = 8850;
    //     UnaryResult<RspGetGameServer> GetGameServer( UserInfo userInfo);
    // }

    //
    // [MemoryPackable]
    // public partial struct RspGetGameServer : INetworkMessage
    // {
    //     public GameServerInfo serverInfo;
    //     public UserInfo userInfo;
    // }
    //
    // [MemoryPackable]
    // public partial struct ReqRpcPacket : INetworkMessage
    // {
    //     public int requestId;
    //     public ArraySegment<byte> data;
    //
    //     public ReqRpcPacket(in int requestId,in ArraySegment<byte> data)
    //     {
    //         this.requestId = requestId;
    //         this.data = data;
    //     }
    // }
    
    // [MemoryPackable]
    // public partial struct RspRpcPacket : INetworkMessage
    // {
    //     public int requestId;
    //     public ArraySegment<byte> data;
    // }
    //

    // public enum RpcErrorCode : byte
    // {
    //     Failed = 0,
    // }

    // [MemoryPackable]
    // public partial struct RpcErrorMessage : INetworkMessage
    // {
    //     public uint requestId;
    //     public RpcErrorCode code;
    //     public string message;
    //
    //     public static RpcErrorMessage From(uint requestId, RpcErrorCode code, string message)
    //     {
    //         return new RpcErrorMessage
    //         {
    //             requestId = requestId,
    //             code = code,
    //             message = message
    //         };
    //     }
    // }

    // public interface ICmdReq: INetworkMessage
    // {
    //     
    // }
    //
    // public interface ICmdRsp: INetworkMessage
    // {
    //     
    // }

    // [MemoryPackable]
    // public partial struct CmdGameServerInfo : ICmdReq
    // {
    // }
    //
    // [MemoryPackable]
    // public partial struct RspCmdServerInfo : ICmdRsp
    // {
    //     public GameServerInfo serverInfo;
    //
    //     public RspCmdServerInfo(GameServerInfo serverInfo)
    //     {
    //         this.serverInfo = serverInfo;
    //     }
    // }
    

    //
    // [MemoryPackable]
    // public partial struct UserInfo
    // {
    // }
    //
    // [MemoryPackable]
    // public partial struct GameServerInfo
    // {
    //     public string ip;
    //     public int port;
    //
    //     public GameServerInfo(string ip, int port)
    //     {
    //         this.ip = ip;
    //         this.port = port;
    //     }
    // }
}