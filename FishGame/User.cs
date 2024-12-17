using MemoryPack;

namespace GameCore.FishGame
{
    [MemoryPackable]
    public partial struct User
    {
        public uint id;
        public string nickname;
    }   
}