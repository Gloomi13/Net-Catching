using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine.Events;

public class Снаряд : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbodyG;
    [SerializeField] private Transform trans;
    [SerializeField] private Vector3 Старт;
    [SerializeField] private Vector3 земля;
    [SerializeField] private Vector3 земляНаправление;
    [SerializeField] private Vector3 mouseWold;
    [SerializeField] private Camera Maincamera;
    [SerializeField] private Vector3 Ноль;
    [SerializeField] private Transform Цель;
    [SerializeField] private GameObject МишеньШаблон;

    public static UnityAction Выстрел;


    void Start()
    {
        rigidbodyG = GetComponent<Rigidbody>();
        Старт = rigidbodyG.transform.position;
        rigidbodyG.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
 
        ПоложениеМыши();
        if(rigidbodyG.transform.position == Старт)
        {
            rigidbodyG.transform.LookAt( Цель);
        }

        if(rigidbodyG.transform.position == Старт)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Выстрел?.Invoke();
                rigidbodyG.transform.DOJump(mouseWold, 0.2f, 0, 3);
                trans.DOLookAt(mouseWold, 0.5f);
                GameObject Мишень = Instantiate(МишеньШаблон, mouseWold, Quaternion.identity);
                // rigidbody.useGravity = true;
            }
        }

                 if (rigidbodyG.transform.position.y <= 0)
        {
            //rigidbody.transform.position = Vector3.Lerp(rigidbody.transform.position, Старт, 100 * Time.deltaTime);
        }
        if (rigidbodyG.transform.position == Ноль)
        {
            rigidbodyG.transform.DOMove(Старт, 0.2f);
 
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Цель>(out Цель цель))
        {
            земля = new Vector3(rigidbodyG.transform.position.x, -1.5f, rigidbodyG.transform.position.z);
            земляНаправление = new Vector3(rigidbodyG.transform.position.x + 0.1f, rigidbodyG.transform.position.y - 180, 0);
            rigidbodyG.transform.DOMove(земля, 2);
            trans.DOLookAt(земляНаправление, 0.2f);
        }

        if (other.TryGetComponent<Полы>(out Полы полы))
        {
            //rigidbody.useGravity = false;
            rigidbodyG.transform.DOMove(Ноль, 3);

        }

    

    }
    public void ПоложениеМыши()
    {
        float enter;

        Ray ray = Maincamera.ScreenPointToRay(Input.mousePosition);

        new Plane(-Vector3.forward, transform.position).Raycast(ray, out enter);
        mouseWold = ray.GetPoint(enter);

        if (mouseWold.y < 0)
        {
            mouseWold = new Vector3(1, 1, 0);
        }

    }
}
