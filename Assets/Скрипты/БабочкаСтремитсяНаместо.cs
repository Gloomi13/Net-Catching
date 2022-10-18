using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class БабочкаСтремитсяНаместо : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    [SerializeField][Range (0,100)]private float step;
    [SerializeField] private int ТочкаСмерти =11;
    [SerializeField] private GameObject Купюра ;

    void Start()
    {
       startPos = transform.localPosition;
    }
 
    void FixedUpdate()
    {
        if(startPos != transform.position)
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, startPos, step * Time.fixedDeltaTime);

       // if(transform.position.x<= ТочкаСмерти)
       // {
        //    GameObject Куп = Instantiate(Купюра, transform.localPosition, Quaternion.identity);
        //    Destroy(gameObject);
      //  }    
    }
}
