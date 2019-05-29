using System;
using Unity.Entities;

/// Authored by <seealso cref="ExampleComponentAuthor"/>
[Serializable]
// ReSharper disable once CheckNamespace
public struct ExampleComponent : IComponentData
{
    public int Value;
}
