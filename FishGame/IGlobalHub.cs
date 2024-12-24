using System.Threading.Tasks;
using MagicOnion;

namespace GameCore.FishGame
{
    /// <summary>
    /// 全局服务
    /// </summary>
    public interface IGlobalHub : IStreamingHub<IGlobalHub, IGlobalHubReceiver>
    {
        ValueTask<StateResponse> GetState(string macToken);


        ValueTask<Error> Login(string macToken);

        ValueTask<Error> Logout(string macToken);

        // ValueTask Heartbeat(uint userId);

        ValueTask Heartbeat(string macToken);
    }

    public interface IGlobalHubReceiver
    {
        void PushTimeMilliSeconds(int milliSeconds);
        void PushMessage(string message);
    }
}