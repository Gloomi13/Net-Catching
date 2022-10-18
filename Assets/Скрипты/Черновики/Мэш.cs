using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Мэш : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("123");
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        Vector3[]  vector3s = new Vector3[3];
        Vector2[]  uv = new Vector2[3]; 
        int[] tria = new int[3];

        vector3s[0]= new Vector3(0,0);
        vector3s[1] = new Vector3(0, 100);
        vector3s[2] = new Vector3(100, 100);

        uv[0] = new Vector2(0, 0);
        uv[1] = new Vector2(0, 1);
        uv[2] = new Vector2(1, 1);

        tria[0] = 0;
        tria[1] = 1;
        tria[2] = 2;

        mesh.vertices = vector3s;
        mesh.uv = uv;
        mesh.triangles = tria;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
