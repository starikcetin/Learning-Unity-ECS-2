# 01 - Converting GameObjects to Entities


## Learning Objectives ##

- Converting GameObjects to Entities.


## Resources ##

- https://github.com/Unity-Technologies/EntityComponentSystemSamples

- https://forum.unity.com/threads/invisible-entity-meshinstancerenderer-or-setsharedcomponentdata-issue.543745


## Notes ##

- Just improting the `Entities` package and attaching the `ConvertToEntity` to a GameObject was not enought to render the resulting Entity. [I also needed to import the `HybridRenderer` package in order to render the converted entities](https://forum.unity.com/threads/invisible-entity-meshinstancerenderer-or-setsharedcomponentdata-issue.543745/#post-4447015).

