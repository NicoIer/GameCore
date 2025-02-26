using Network;
using UnityToolkit.MathTypes;

namespace GameCore.Position
{
    public partial struct CmdPositionEntity : INetworkMessage
    {
        public uint entityId;
        public Vector3 position;
        public Quaternion rotation;
    }
}