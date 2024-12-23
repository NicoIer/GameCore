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
        public Error error;
    }

    [MemoryPackable]
    public partial struct Error
    {
        public StatusCode code;
        public string msg;

        public static readonly Error Success = new Error { code = StatusCode.Success };
        public static readonly Error Failed = new Error { code = StatusCode.Failed };
        public static readonly Error UserNotFound = new Error { code = StatusCode.Failed, msg = "User not found" };
        public static readonly Error RoomNotFound = new Error { code = StatusCode.Failed, msg = "Room not found" };
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