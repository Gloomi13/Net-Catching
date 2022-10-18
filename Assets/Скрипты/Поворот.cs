using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Поворот : MonoBehaviour
{
    [SerializeField] Transform STransform1;
    [SerializeField] float Угол1;
    [SerializeField] float Угол2;
    [SerializeField] float Угол3;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        STransform1.eulerAngles = new Vector3(Угол1, Угол2, Угол3);
    }
}
