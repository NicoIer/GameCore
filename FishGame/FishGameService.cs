using System.Threading.Tasks;
using MagicOnion;

namespace GameCore.FishGame
{
    /// <summary>
    /// Client -> Server
    /// </summary>
    public interface IFishGameHud : IStreamingHub<IFishGameHud, IFishGameHudReceiver>
    {
        ValueTask JoinAsync(uint uid);
        ValueTask ReadyAsync(uint uid);
        ValueTask LeaveAsync(uint uid);
    }


    /// <summary>
    /// Server -> Client
    /// </summary>
    public interface IFishGameHudReceiver
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