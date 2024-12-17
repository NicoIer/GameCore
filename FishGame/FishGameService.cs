using System.Threading.Tasks;
using MagicOnion;
using MemoryPack;
using MessagePack;

namespace GameCore.FishGame
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public enum UserState : byte
    {
        None,
        Login, // 登录
        Hall, // 大厅
        Gaming, // 游戏中
    }

    /// <summary>
    /// 网络状态码
    /// </summary>
    public enum StatusCode : byte
    {
        Success,
        Failed,
    }

    [MemoryPackable]
    // [MessagePackObject]
    public partial struct RegisterResult
    {
        // [Key(0)]
        public uint userId;
        // [Key(1)]
        public StatusCode code;
    }

    /// <summary>
    /// 全局服务
    /// </summary>
    public interface IGlobalService : IStreamingHub<IGlobalService, IGlobalServiceReceiver>
    {
        // ValueTask<RegisterResult> Register(string nickName);
        ValueTask<UserState> GetState(uint userId);
        ValueTask<StatusCode> Login(uint userId);
        ValueTask<StatusCode> Logout(uint userId);
    }

    public interface IGlobalServiceReceiver
    {
    }

    /// <summary>
    /// 大厅服务
    /// </summary>
    public interface IHallService : IService<IHallService>
    {
        UnaryResult<StatusCode> Enter(string userId);
        UnaryResult<string> Match(string userId);
        UnaryResult Leave(string userId);
    }


    public enum GameState : byte
    {
        None,
        Joined,
        Ready,
        Gaming,
        Win,
        Failed,
    }

    /// <summary>
    /// Client -> Server
    /// </summary>
    public interface IFishGameHud : IStreamingHub<IFishGameHud, IFishGameHudReceiver>
    {
        ValueTask JoinAsync(string userId);
        ValueTask ReadyAsync(string userId);
        ValueTask LeaveAsync(string userId);
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
    }
}