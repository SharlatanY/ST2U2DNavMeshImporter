using NavMeshSurface2DBaker;
using SuperTiled2Unity;
using SuperTiled2Unity.Editor;
using UnityEngine;
using UnityEngine.AI;

namespace ST2U2DNavMeshImporter
{
  //[AutoCustomTmxImporter]
  public class CustomImporter_2DNavMesh : CustomTmxImporter
  {
    public override void TmxAssetImported(TmxAssetImportedArgs args)
    {
      var map = args.ImportedSuperMap;
      var navMeshGameObject = CreateNavMeshObject(map);

      navMeshGameObject.transform.parent = map.transform;
    }

    private static GameObject CreateNavMeshObject(SuperMap map)
    {
      var go = GameObject.CreatePrimitive(PrimitiveType.Plane);
      go.name = "NavMesh";
      go.transform.rotation = Quaternion.Euler(270,0,0);
      go.AddComponent<NavMeshSurface>();
      var surfaceBaker = go.AddComponent<Surface2DBaker>();
      surfaceBaker.ObjectsContainingObstacles.Add(map.gameObject);

      go.GetComponent<MeshRenderer>().enabled = false;
      go.GetComponent<MeshCollider>().enabled = false;

      SetNavMeshPlaneScaleAndPosition(go, map);

      return go;
    }

    private static void SetNavMeshPlaneScaleAndPosition(GameObject navMeshGameObject, SuperMap map)
    {
      var scaleX = map.m_Width * map.m_TileWidth / 10;
      var scaleZ = map.m_Height * map.m_TileHeight / 10;
      var posX = map.m_Width * map.m_TileWidth / 2;
      var posY = -(map.m_Height * map.m_TileHeight / 2);
      
      navMeshGameObject.transform.position = new Vector3(posX, posY, 0);
      navMeshGameObject.transform.localScale = new Vector3(scaleX, 0, scaleZ);
    }
  }
}
