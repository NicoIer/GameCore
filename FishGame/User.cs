using GameCore.FishGame;
using MemoryPack;

namespace FishGame
{
    [MemoryPackable]
    public sealed partial class User
    {
        public int id { get; set; }
        // public uint uid { get; set; }
        public string nickname { get; set; }
        public GlobalState globalState { get; set; }

        public GameState gameState { get; set; }
        
        /// <summary>
        /// 账号对应的MAC地址
        /// </summary>
        public string macToken { get; set; }

        public float lastActionTimeSeconds { get; set; }
    }
}