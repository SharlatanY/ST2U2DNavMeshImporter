# ST2U2DNavMeshImporter
About
---
ST2U2DNavMeshImporter is a Unity Package that provides a custom importer to automatically setting up 2D Navmeshes (using [NavMeshSurface2DBaker](https://github.com/SharlatanY/NavMeshSurface2DBaker)) when importing [Tiled](https://www.mapeditor.org/) tilempas through [SuperTiled2Unity](https://seanba.itch.io/supertiled2unity).

![](https://raw.githubusercontent.com/SharlatanY/ST2U2DNavMeshImporter/master/docs/img/tilemap_navmesh.png)

Prerequisites
---
* [SuperTiled2Unity](https://github.com/Seanba/SuperTiled2Unity)
* [Unity NavMeshComponents](https://github.com/Unity-Technologies/NavMeshComponents)

Usage
---
1. In Unity, go to your tilemap and set *Custom Importer* to *CustomImporter_2DNavMesh*. Alternatively, if you want to generate NavMeshes for all your tilemaps, uncomment the *\[AutoCustomTmxImporter\]* attribute in *CustomImporter_2DNavMesh.cs*
2. On the *ST2U Settings* object, press the "Reimport Tiled Assets"-Button.
3. In the scene where your tiled map is being used, search the tilemap object for a "NavMesh" child and select it.
4. On this child, there's a *Surface2DBaker* component. Press the "Bake 2D"-button on this script to generate the *NavMesh*.

FAQ
---
### What collider types are being supported?
* BoxCollider2D
* CircleCollider2D
* PolygonCollider2D
* CompositeCollider2D
* TilemapCollider2D (For those to work, you have to make them part of a CompositeCollider2D, though!)

### Baking takes a really long time, even for a small map, why is that?
Your NavMeshAgent radius is probably way too small. Experiment with the radius until you find a radius that's as big as possible while still giving you accurate results.

### The resulting mesh is very inaccurate, why is that?
Your NavMeshAgent radius is probably too big. Experiment with the radius until you find a radius that's as big as possible while still giving you accurate results.

### Is there a way so I don't have to press the bake button?
Not at this moment, unfortunately. At the moment I don't see a clear solution for this which I could implement in a clean and simple manner. Figuring this out would probably take some time I'd rather spend on other projects as long as there's no need for it. But let me know if that's a must have feature for you and I'll see what I can do!

Compatibility
---
Current version tested with:
* Unity 2018.3.0f2
* SuperTiled2Unity 1.1.9
* Unity NavMeshComponents 2018.3.0f2

3rd party components provided with project
---
* [SuperTiled2Unity](https://github.com/Seanba/SuperTiled2Unity) (MIT license, for full license details see subfolder *SuperTiled2Unity*)
* [Unity NavMeshComponents](https://github.com/Unity-Technologies/NavMeshComponents) (MIT license, for full license details see subfolder *NavMeshComponents*)
