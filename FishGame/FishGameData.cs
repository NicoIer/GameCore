using MemoryPack;

namespace GameCore.FishGame
{
    [MemoryPackable]
    public partial class GameWorld
    {
    }

    [MemoryPackable]
    public partial struct RegisterResponse
    {
        public uint userId;
        public Error error;
    }
    
    public partial struct Error
    {
        public StatusCode code;
        public string msg;
        
        public static readonly Error Success = new Error { code = StatusCode.Success };
        public static readonly Error Failed = new Error { code = StatusCode.Failed };
    }

    [MemoryPackable]
    public partial struct FishGamePlayer
    {
        public readonly uint userId;
        public string name;

        public FishGamePlayer(uint userId, string name)
        {
            this.userId = userId;
            this.name = name;
        }
    }
}