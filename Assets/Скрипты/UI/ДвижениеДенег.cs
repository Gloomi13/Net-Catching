using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ДвижениеДенег : MonoBehaviour
{
    [SerializeField] private Transform startPos;
    [SerializeField] private Transform Старт;
    [SerializeField] private Camera Камера;
    [SerializeField] private RectTransform trans;
    [SerializeField] private RectTransform Цель;
    [SerializeField] private RectTransform Стартовая;

    public GameObject obj;

    [SerializeField] int q = -70;
    [SerializeField] int w= -185;
    [SerializeField] float e = -460f;
    [SerializeField] float r = -865f;

    [SerializeField] int s= 0;

    void Awake()
{
    obj = GameObject.Find("финишь");
        
}

    void Start()
    {
        // transform.position = Камера.WorldToScreenPoint(Старт.position);
        // trans.transform.SetParent(canvas.transform); // setting parent
        //trans.localScale = Vector3.one;
        //trans.anchoredPosition = new Vector2(-70f, -185f); // setting position, will be on center
       // trans.sizeDelta = new Vector2(-460, -865); // custom size


    }
    // Update is called once per frame
    void Update()
    {
       // trans.localScale = Vector3.one;
       // trans.anchoredPosition = new Vector2(q, w); // setting position, will be on center
       // trans.sizeDelta = new Vector2(e, r); // custom size



       // var eee = Камера.WorldToScreenPoint(Старт.position);
       // Debug.Log(eee);
      // transform.position = Vector3.Lerp(startPos.position , transform.position, s * Time.deltaTime);

       if(transform.position== startPos.position)
          {
            //Destroy(gameObject);
          }

        transform.position = Vector3.Lerp(transform.position, obj.transform.position, s * Time.deltaTime);
    }
}
