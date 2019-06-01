# 01 - Converting GameObjects to Entities


## Learning Objectives ##

- Converting GameObjects to Entities.

- Setting up ECS Component data in Author MonoBehaviours.


## Sections ##

- [01.A - Convert and Destroy](/01%20-%20Converting%20GameObjects%20to%20Entities/Assets/01.A%20-%20Convert%20and%20Destroy)

- [01.B - Convert and Inject GameObject](/01%20-%20Converting%20GameObjects%20to%20Entities/Assets/01.B%20-%20Convert%20and%20Inject%20GameObject)

- [01.C - Authoring](/01%20-%20Converting%20GameObjects%20to%20Entities/Assets/01.C%20-%20Authoring)

- [01.D - Sub Scene](/01%20-%20Converting%20GameObjects%20to%20Entities/Assets/01.D%20-%20Sub%20Scene)


## Resources ##

- https://github.com/Unity-Technologies/EntityComponentSystemSamples

- https://forum.unity.com/threads/invisible-entity-meshinstancerenderer-or-setsharedcomponentdata-issue.543745


## Notes ##

- Importing the `Entities` package and attaching the `ConvertToEntity` to a GameObject was not enought to render the resulting Entity. [I also needed to import the `HybridRenderer` package in order to render the converted entities](https://forum.unity.com/threads/invisible-entity-meshinstancerenderer-or-setsharedcomponentdata-issue.543745/#post-4447015).

