using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using DG.Tweening;

public class PriChel : MonoBehaviour
{
    [SerializeField] private Camera Maincamera;
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject Стрела;
    public СледСтрельбы cледСтрельбы;
    [SerializeField] private float Power =0.1f;

    private Vector3 mousePos;


    private void Start()
    {
        Maincamera= Camera.main;
    }

    private void Update()
    {
        float enter;

        Ray ray = Maincamera.ScreenPointToRay(Input.mousePosition);

        new Plane(-Vector3.forward, transform.position).Raycast(ray, out enter);
        Vector3 mouseWold = ray.GetPoint(enter);
        


        Vector3 speed = (mouseWold ) * Power;
        float Уголx2 = Mathf.Clamp(speed.x, 0, 85);
        Vector3 speed2 = new Vector3(Уголx2, speed.y, speed.z);
        transform.rotation = Quaternion.LookRotation(speed2);

        cледСтрельбы.ShowTrajctorry(transform.position, speed2);

        if (Input.GetMouseButtonDown(0) )
        {
            Rigidbody rigidbody = Стрела.GetComponent<Rigidbody>();
            rigidbody.AddForce(speed2, ForceMode.VelocityChange);


        }
    }

    private void FixedUpdate()
    {
       
    }

}
