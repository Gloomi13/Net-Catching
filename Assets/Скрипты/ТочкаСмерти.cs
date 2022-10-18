using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ТочкаСмерти : MonoBehaviour
{
    public static UnityAction Поймал;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<БабочкаСтремитсяНаместо>(out БабочкаСтремитсяНаместо бабочка))
        {
            Destroy(бабочка.gameObject);
            Поймал?.Invoke();
        }
    }
}
