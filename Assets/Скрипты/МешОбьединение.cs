using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class МешОбьединение : MonoBehaviour
{
    [SerializeField] private List<MeshFilter> meshFilters;
    [SerializeField] private MeshFilter tarMeshFilter;

   
    void Update()
    {
        var cobine = new CombineInstance[meshFilters.Count];
        for(var i =0; i < meshFilters.Count; i++)
        {
            cobine[i].mesh = meshFilters[i].sharedMesh;
            cobine[i].transform = meshFilters[i].transform.localToWorldMatrix;
        }

        var mesh = new Mesh();
        mesh.CombineMeshes(cobine, true, false, false);
 
        tarMeshFilter.mesh = mesh;
        
    }
}
