# 01.D - Sub Scene #

Moving some section of a Master Scene into Sub Scenes.

In this example, Master Scene has a Sub Scene named Sphere. Click on it to see the details of the `SubScene` script, which is responsible for loading the Sub Scene. Notice the `Auto Load Scene` option.


## Notes ## 

- `ConvertToEntity` is not required for proxy GameObjects in a Sub Scene. `SubScene` converts them itself.

- Creating a SubScene:

    - Select a portion of your hierarchy.

    - Right click on the selection.
    
    - Click on `New SubScene From Selection` option.
    
    - A new Sub Scene will be created under a folder with the same name as the Master Scene, in the same directory. Unity automatically creates a GameObject in the Master Scene with a `SubScene` script on it and links it with your newly created Sub Scene.
