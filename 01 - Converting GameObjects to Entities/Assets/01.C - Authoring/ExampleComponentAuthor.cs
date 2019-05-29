using Unity.Entities;
using UnityEngine;

/// Author for <seealso cref="ExampleComponent"/>
[DisallowMultipleComponent]
[RequiresEntityConversion]
// ReSharper disable once CheckNamespace
public class ExampleComponentAuthor : MonoBehaviour, IConvertGameObjectToEntity
{
    [SerializeField] private int _value;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new ExampleComponent { Value = _value });
    }
}
