using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Common.PhysicService
{
    public interface IPhysicsService
    {
        IEnumerable<GameEntity> RaycastAll(Vector3 worldPosition, Vector3 direction, float maxDistance, int layerMask);
        GameEntity Raycast(Vector3 worldPosition, Vector3 direction, float maxDistance, int layerMask);
        GameEntity LineCast(Vector3 start, Vector3 end, int layerMask);
        IEnumerable<GameEntity> CircleCast(Vector3 position, float radius, int layerMask);
        int CircleCastNonAlloc(Vector3 position, float radius, int layerMask, GameEntity[] hitBuffer);
        int OverlapSphere(Vector3 worldPos, float radius, Collider[] hits, int layerMask); 
    }
}