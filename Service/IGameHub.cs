using System.Threading.Tasks;
using MagicOnion;

namespace GameCore.Service
{
    public interface IGameHubReceiver
    {
        void OnReceiveMessage(string message);
    }
    
    public interface IGameHub : IStreamingHub<IGameHub, IGameHubReceiver>
    {
        ValueTask SendMessageAsync(string message);
    }
}