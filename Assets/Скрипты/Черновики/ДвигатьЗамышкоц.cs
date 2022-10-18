using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ДвигатьЗамышкоц : MonoBehaviour
{
    public Transform Цель;
    [SerializeField] private Camera Maincamera;
    [SerializeField] private GameObject МишеньШаблон;
    [SerializeField] private Vector3 mouseWold;

    void Start()
    {
        Maincamera = Camera.main;
        
    }

    void Update()
    {
        float enter;
        Ray ray = Maincamera.ScreenPointToRay(Input.mousePosition);
        new Plane(-Vector3.forward, transform.position).Raycast(ray, out enter);
        mouseWold = ray.GetPoint(enter);

        if (mouseWold.y < 0)
        {
            mouseWold = new Vector3(1, 1, 0);
        }

        Цель.position = mouseWold;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject Мишень = Instantiate(МишеньШаблон, mouseWold, Quaternion.identity);
        }

    }
}
