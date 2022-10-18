using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class МешпоКоординат : MonoBehaviour
{

    Mesh mesh;
    [SerializeField] private Vector3[] vectors;
    public int[] tr;

    [SerializeField] private Transform[] vectors2;
   private Vector2[] uvs;


    void Start()
    {
        uvs = new Vector2[vectors2.Length];
        vectors = new Vector3[vectors2.Length];
        tr = new int[6];
        tr[0] = 0;
        tr[1] = 1;
        tr[2] = 2;
        tr[3] = 2;
        tr[4] = 1;
        tr[5] = 3;
    }

    // Update is called once per frame
    void Update()
    {
        vectors[0] = new Vector3(vectors2[0].position.x, vectors2[0].position.y);
        vectors[1] = new Vector3(vectors2[1].position.x, vectors2[1].position.y);
        vectors[2] = new Vector3(vectors2[2].position.x, vectors2[2].position.y);
        vectors[3] = new Vector3(vectors2[3].position.x, vectors2[3].position.y);
        // vectors[4] = new Vector3(vectors2[4].position.x, vectors2[4].position.y);
        // vectors[5] = new Vector3(vectors2[5].position.x, vectors2[5].position.y);
        // vectors[6] = new Vector3(vectors2[6].position.x, vectors2[6].position.y);
        // uvs[0] = new Vector2(vectors2[0].position.x, vectors2[0].position.y);
        // uvs[1] = new Vector2(vectors2[1].position.x, vectors2[1].position.y);
        //  uvs[2] = new Vector2(vectors2[2].position.x, vectors2[2].position.y);
        //  uvs[3] = new Vector2(vectors2[3].position.x, vectors2[3].position.y);

        uvs[0] = new Vector2(0, 0);
       uvs[1] = new Vector2(1, 0);
       uvs[2] = new Vector2(1, 1);
        uvs[3] = new Vector2(0, 1);
   


         mesh = GetComponent<MeshFilter>().mesh;
        mesh.vertices = vectors;
        mesh.triangles = tr;
       mesh.uv= uvs;
        mesh.RecalculateBounds();
    }
}
