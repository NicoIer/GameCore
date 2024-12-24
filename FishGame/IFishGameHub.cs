using System;
using System.Threading.Tasks;
using MagicOnion;
using MemoryPack;

namespace GameCore.FishGame
{
    /// <summary>
    /// Client -> Server
    /// </summary>
    public interface IFishGameHub : IStreamingHub<IFishGameHub, IGameHudReceiver>
    {
        ValueTask<Error> JoinAsync(string macToken, uint roomId);
        ValueTask<Error> ReadyAsync(string macToken);
        ValueTask LeaveAsync(string macToken);
        ValueTask<MatchRoomResponse> MatchRoom(string macToken);
    }

    [MemoryPackable]
    public partial struct MatchRoomResponse
    {
        public uint roomId;
        public Error error;
    }
    


    /// <summary>
    /// Server -> Client
    /// </summary>
    public interface IGameHudReceiver
    {
        /// <summary>
        /// 服务器对时，向客户端推送当前游戏时间戳
        /// </summary>
        /// <param name="milliSeconds"></param>
        void PushTimeMilliSeconds(long milliSeconds);

        void PushGameState(GameState state);

        void PushGame(in GameWorld gameWorld);
    }
}