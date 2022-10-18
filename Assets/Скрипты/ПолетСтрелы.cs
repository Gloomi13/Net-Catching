using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class ПолетСтрелы : MonoBehaviour

{
    [SerializeField] private new Rigidbody rigidbody;
    [SerializeField] private Camera Maincamera;
    Vector3 Старт;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Старт = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float enter;

        Ray ray = Maincamera.ScreenPointToRay(Input.mousePosition);

        new Plane(-Vector3.forward, transform.position).Raycast(ray, out enter);
        Vector3 mouseWold = ray.GetPoint(enter);

        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.AddForce(10,10,0, ForceMode.VelocityChange);
             //transform.DOJump(mouseWold, 1, 1,1);
            // transform.DOLookAt(mouseWold, 2, 0f);


        }

        if(transform.position.y <=1.5f)
        {
            //transform.position = Vector3.Lerp(transform.position, Старт, 10 * Time.deltaTime);
        }
    }
}
