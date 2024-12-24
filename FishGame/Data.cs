using MemoryPack;

namespace GameCore.FishGame
{
    [MemoryPackable]
    public partial class GameWorld
    {
        public readonly uint worldId;

        public GameWorld(in uint worldId)
        {
            this.worldId = worldId;
        }
    }

    [MemoryPackable]
    public partial struct RegisterResponse
    {
        public uint userId;
        public long token;
        public Error error;
    }

    [MemoryPackable]
    public partial struct Error
    {
        public StatusCode code;
        public string msg;

        public static readonly Error success = new Error { code = StatusCode.Success };
        public static readonly Error failed = new Error { code = StatusCode.Failed };
        public static readonly Error userNotFound = new Error { code = StatusCode.Failed, msg = "User not found" };
        public static readonly Error roomNotFound = new Error { code = StatusCode.Failed, msg = "Room not found" };

        public static readonly Error nickNameAlreadyExists =
            new Error { code = StatusCode.Failed, msg = "NickName already exists" };
    }

    [MemoryPackable]
    public partial struct StateResponse
    {
        public GlobalState state;
        public Error error;
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