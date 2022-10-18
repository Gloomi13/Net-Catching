using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СтрелаДвижение : MonoBehaviour
{
    public GameObject цель;
    [SerializeField][Range(0, 100)] private float step;
    private bool Попала=true;
    private bool Наземле = false;
    new Rigidbody rigidbody;
    Vector3 Старт;

    void Start()
    {
        цель = GameObject.FindGameObjectWithTag("Цель");
        rigidbody = GetComponent<Rigidbody>();
        Старт = transform.position;
    }

    
    void Update()
    {
        if(Попала)
            transform.LookAt(цель.transform);
    
        if (Наземле)
            transform.position = Vector3.Lerp(transform.position, Старт, 10 * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Цель>(out Цель цель))
        {
            Попала = false;
           // rigidbody.velocity = new Vector3(0, -10, 0);
            rigidbody.AddForce(0, -10, 0, ForceMode.VelocityChange);
            transform.LookAt(Vector3.down);
           // transform.rotation = Quaternion.LookRotation(rigidbody.velocity);
        }
        if (other.TryGetComponent<Полы>(out Полы полы))
        {
            Наземле = true;
        }

    }
}
