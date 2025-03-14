using System;
using System.Buffers;
using MemoryPack;
using Network;
using UnityToolkit.MathTypes;

namespace GameCore.PhysX
{
    public interface INetworkEntity
    {
        public int ownerId { get; } // player id
        public uint entityId { get; } // entity id
        public byte worldId { get; }
    }

    [MemoryPackable]
    public partial struct PhysXRigidBody : INetworkEntity
    {
        public int ownerId { get; set; } // player id
        public uint entityId { get; set; } // entity id
        public byte worldId { get; set; }

        public Vector3 velocity;
        public Vector3 angularVelocity;

        public float drag;
        public float angularDrag;
        public float mass;
        public bool useGravity;
        public float maxDepenetrationVelocity;
        public bool isKinematic;
        public bool freezeRotation;

        public RigidbodyConstraints constraints;
        public CollisionDetectionMode collisionDetectionMode;

        public Vector3 centerOfMass;
        public Vector3 worldCenterOfMass;

        public Vector3 inertiaTensor;

        public bool detectCollisions;

        public Vector3 position;
        public Quaternion rotation;

        public int solverIterations;

        public float sleepThreshold;

        public float maxAngularVelocity;

        public float solverVelocityIterations;

        public PhysXCollider collider;
    }

    [MemoryPackable]
    public partial struct PhysXCollider
    {
        public ColliderType type;
        public ArraySegment<byte> data;
    }
}