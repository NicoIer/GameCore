using System;
using MemoryPack;
using Network;
using UnityToolkit.MathTypes;

namespace GameCore.Position
{
    [MemoryPackable]
    public partial struct PositionEntity
    {
        public int ownerId;
        public uint entityId;
        public Vector3 position;
        public Quaternion rotation;

        public PositionEntity(in int connectId, in uint entityId, in Vector3 spawnPoint, in Quaternion identity)
        {
            ownerId = connectId;
            this.entityId = entityId;
            position = spawnPoint;
            rotation = identity;
        }
    }

    [MemoryPackable]
    public partial struct WorldSnapshot : INetworkMessage
    {
        public long timestamp;
        public ArraySegment<PositionEntity> entities;
    }
}