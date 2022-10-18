using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СледСтрельбы : MonoBehaviour
{
    private LineRenderer lineRendererCom;
   
    void Start()
    {
        lineRendererCom = GetComponent<LineRenderer>();
    }

    public void ShowTrajctorry(Vector3 ori,Vector3 speed)
    {
        Vector3[] points = new Vector3[10];

        lineRendererCom.positionCount = points.Length;

        for (int i = 0; i < points.Length; i++)
        {
            float time = i * 0.1f;
            points[i] = ori + speed * time + Physics.gravity * time * time / 2f;

            if (points[i].y>14|| points[i].x>14)
            {
                lineRendererCom.positionCount = i;
                break;
            }
        }

        lineRendererCom.SetPositions(points);
    }
}
