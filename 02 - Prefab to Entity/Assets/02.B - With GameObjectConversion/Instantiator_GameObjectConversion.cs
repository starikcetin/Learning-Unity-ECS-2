using Unity.Entities;
using UnityEngine;

public class Instantiator_GameObjectConversion : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    private void Start()
    {
        // Convert the *Prefab* to an Entity.
        // This does not instantiate the prefab, it just registers the prefab to ECS ecosystem
        // so we can use it later on.
        var prefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(_prefab, World.Active);

        // Now instantiate another Entity out of it.
        var entityManager = World.Active.EntityManager;
        var entity = entityManager.Instantiate(prefab);
    }
}
