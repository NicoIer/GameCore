using MessagePack;

namespace GameCore
{
    [MessagePackObject]
    public class DummyMessage
    {
        [MessagePack.Key(0)]
        public int Id { get; set; }
        [MessagePack.Key(1)]
        public string Name { get; set; }
    }   
}