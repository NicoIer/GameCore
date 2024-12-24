using MagicOnion;

namespace GameCore.FishGame
{
    /// <summary>
    /// 大厅服务
    /// </summary>
    public interface IHallService : IService<IHallService>
    {
        UnaryResult<StatusCode> Enter(string userId);
        UnaryResult<string> Match(string userId);
        UnaryResult Leave(string userId);
    }
}