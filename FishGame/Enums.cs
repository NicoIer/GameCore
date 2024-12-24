using MemoryPack;

namespace GameCore.FishGame
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public enum GlobalState : byte
    {
        Offline,
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


    public enum GameState : byte
    {
        None,
        Joined,
        Ready,
        Gaming,
        Win,
        Failed,
    }
}