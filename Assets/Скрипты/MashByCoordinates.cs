using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MashByCoordinates : MonoBehaviour
{

    [SerializeField] private Transform[] Coordinates;
    private Mesh mesh;
    private Vector3[] vectors;
    private Vector2[] uvs;
    private int[] tr;

    void Start()
    {
        uvs = new Vector2[Coordinates.Length];
        vectors = new Vector3[Coordinates.Length];
        tr = new int[6];
        tr[0] = 0;
        tr[1] = 1;
        tr[2] = 2;
        tr[3] = 2;
        tr[4] = 1;
        tr[5] = 3;
    }

    void Update()
    {
        vectors[0] = new Vector3(Coordinates[0].position.x, Coordinates[0].position.y);
        vectors[1] = new Vector3(Coordinates[1].position.x, Coordinates[1].position.y);
        vectors[2] = new Vector3(Coordinates[2].position.x, Coordinates[2].position.y);
        vectors[3] = new Vector3(Coordinates[3].position.x, Coordinates[3].position.y);

        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(1, 0);
        uvs[2] = new Vector2(1, 1);
        uvs[3] = new Vector2(0, 1);
 
        mesh = GetComponent<MeshFilter>().mesh;
        mesh.vertices = vectors;
        mesh.triangles = tr;
        mesh.uv = uvs;
        mesh.RecalculateBounds();
    }
}
