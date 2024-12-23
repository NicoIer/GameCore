using System.Threading.Tasks;
using MagicOnion;

namespace GameCore.FishGame{
    /// <summary>
    /// 全局服务
    /// </summary>
    public interface IGlobalHud : IStreamingHub<IGlobalHud, IGlobalServiceHubReceiver>
    {
        ValueTask<RegisterResponse> Register(string nickName);
        ValueTask<UserState> GetState(uint userId);
        ValueTask<StatusCode> Login(uint userId);
        ValueTask<StatusCode> Logout(uint userId);
        void SendHeartbeat(uint userId);
    }

    public interface IGlobalServiceHubReceiver
    {
        ValueTask<long> PushTimeMilliSeconds(long milliSeconds);
        ValueTask<string> PushMessage(string message);
    }

}