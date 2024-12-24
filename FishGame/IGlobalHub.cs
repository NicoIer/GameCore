using System.Threading.Tasks;
using MagicOnion;

namespace GameCore.FishGame{
    /// <summary>
    /// 全局服务
    /// </summary>
    public interface IGlobalHub : IStreamingHub<IGlobalHub, IGlobalHubReceiver>
    {
        ValueTask<RegisterResponse> Register(string nickName);
        ValueTask<StateResponse> GetState(uint userId);
        ValueTask<Error> Login(uint userId);
        ValueTask<Error> Logout(uint userId);
        ValueTask Heartbeat(uint userId);
    }

    public interface IGlobalHubReceiver
    {
        void PushTimeMilliSeconds(int milliSeconds);
        void PushMessage(string message);
    }

}