using System.Threading.Tasks;
using MagicOnion;

namespace GameCore.Service
{
    public interface IGameService :
        IService<IGameService>
    {
        UnaryResult<int> SumAsync(int x, int y);
    }
}