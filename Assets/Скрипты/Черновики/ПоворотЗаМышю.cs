using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ПоворотЗаМышю : MonoBehaviour
{
   public Transform Спаунер;
    public Transform Цель;
    [SerializeField] private GameObject prefab;
    [Range(0,360)]public float Угол;
    float g = Physics.gravity.y;


    void Start()
    {
        
    }


    void Update()
    {
        Vector3 www = Цель.position - transform.position;
        Спаунер.eulerAngles = new Vector3(Угол, Угол, Угол);
       

        if (Input.GetMouseButtonDown(0))
        { 
          //  Выстрел();
        }

    }

   public void Выстрел()
    {
        Vector3 СмотретьНаЦель = Цель.position - transform.position;
        Vector3 СмотретьНаЦельXZ = new Vector3(СмотретьНаЦель.z, 0f, СмотретьНаЦель.z);
        transform.rotation = Quaternion.LookRotation(СмотретьНаЦель, Vector3.up);
      

        float x = СмотретьНаЦель.magnitude;
        float y = СмотретьНаЦель.y;

        float УголРадианы = Угол * Mathf.PI / 180;

        float v2 = (g * x * x) / 2 * (y - Mathf.Tan(УголРадианы) * x) * Mathf.Pow(Mathf.Cos(УголРадианы), 2);
        float v = Mathf.Sqrt(Mathf.Abs(v2));
       
        GameObject Стрела = Instantiate(prefab, Спаунер.position, Спаунер.rotation);
        
        Стрела.GetComponent<Rigidbody>().velocity = Спаунер.forward * v;
    }
}
