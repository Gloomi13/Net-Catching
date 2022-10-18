using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Цель : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Снаряд>(out Снаряд стрелаДвижение))
        {
          Invoke("Удалить", 1f);
        }
    }
    private void Удалить()
    {
        Destroy(gameObject);
    }
}
