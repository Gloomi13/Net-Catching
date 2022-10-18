using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class АминацияБаьочки : MonoBehaviour
{
    [SerializeField][Range(0, 1)] private float ТочкаСтарта;
    private Animation anim;


    private void Awake()
    {
        anim = GetComponent<Animation>();
    }

    void Start()
    {
       anim["БабочкаМашет"].normalizedTime = ТочкаСтарта;
    }
}
