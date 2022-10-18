using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Меш22 : MonoBehaviour
{
    float w = 50f;
    float h = 50f;
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        meshFilter.mesh = mesh;

        Vector3[] vert = new Vector3[4]
        {
            new Vector3 (0,0,0), new Vector3(w, 0, 0), new Vector3(0, h, 0), new Vector3(w, h, 0)
        };

        int[] ints = new int[6];
        ints[0]=0;
        ints[1] = 2;
        ints[2] = 1;

        ints[3] = 2;
        ints[4] = 3;
        ints[5] = 1;

        mesh.vertices = vert;
        mesh.triangles = ints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
