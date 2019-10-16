# 01.C - Authoring #
Setting up ECS component data from Author MonoBehaviour scripts.

## Procedure ##

`IConvertGameObjectToEntity` interface interface provides a `void Convert(Entity, EntityManager, GameObjectConversionSystem)` method. The Entity in the first parameter is the Entity created for this GameObject by the `ConvertToEntity` script.

Therefore, we can add our ECS Component to this Entity, in that method.

`ExampleComponentAuthor` adds an `ExampleComponent` to the Entity, setting it's `Value` field to `_value` field of itself.

Now we can set the value from the inspector, and it will be transferred to our Entity.

Check it out with the Entity Debugger window.

## Notes ## 

- I like the use of interfaces. Go Unity!

- Being able to use the interface to set-up the ECS world is a big improvement.

- Entity Debugger can be found under the Windows > Analysis menu.
