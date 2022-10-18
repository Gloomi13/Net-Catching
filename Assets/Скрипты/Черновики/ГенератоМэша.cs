using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))] 
public class ГенератоМэша : MonoBehaviour
{
    [SerializeField] private int _xСетки, _yСетки;


    private Vector3[] vertices;
    private Mesh _mesh;

    // Start is called before the first frame update
    void Start()
    {
        Создать();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Создать()
    {
        vertices = new Vector3[(_xСетки+1)* (_yСетки+1)];
        for (int i = 0, y = 0; y < _yСетки; y ++)
            {
            for (int x = 0; x < _xСетки; x++)
            {
                vertices[i] = new Vector3(x, y);
            }
        }
    }

    private void OnDrawGizmos()
    {
        _mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = _mesh;
        _mesh.name = "Grid";
        if (vertices== null)
        {
            return;
        }
        Gizmos.color = Color.red;
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], 0.2f);
        }
        _mesh.vertices = vertices;


        int[] tri = new int[6];
        tri[0] = 0;
        tri[1] = _xСетки + 1;
        tri[2] = 1;
        tri[3] = 1;
        tri[4] = _yСетки + 1;
        tri[5] = _xСетки + 2;

        _mesh.triangles = tri;
    }

}
