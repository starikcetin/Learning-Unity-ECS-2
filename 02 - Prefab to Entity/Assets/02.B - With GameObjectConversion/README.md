
02.B - With GameObjectConversion
---

1. Converts the Prefab to an Entity representation using `GameObjectConversionUtility.ConvertGameObjectHierarchy(GameObject, World)`, passing in the Prefab and the ECS world.

2. Instantiates it using `World.Instantiate(Entity)`, passing in the Entity we get from _step #1_.


Notes
---

- This is the way ECS gods intended.
	- _By "gods", I mean Mike Acton, Mike Acton, and Mike Acton. Did I mention Mike Acton?_

- `World.Active` returns the active ECS world. So I just used it for the second parameter in _step #1_.

	- Ugghhh... I know, I know. Singletons. However, I believe Unity guys know what they are doing this time. So I'm going to ignore the elephant in the room for now.
