using System;
using Unity.Entities;

/// Authored by <seealso cref="ExampleComponentAuthor"/>
[Serializable]
public struct ExampleComponent : IComponentData
{
    public int Value;
}
