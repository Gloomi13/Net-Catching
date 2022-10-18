using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СпаунерКупьр : MonoBehaviour
{
    [SerializeField] private GameObject Префаб;

    [SerializeField] private Transform Канвас;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Ссылка на канвас или на объект в который вы хотите создать дочерний объект
        var trans = Instantiate(Префаб, Канвас.transform);
        RectTransform tra = trans.GetComponent<RectTransform>();
        tra.localScale = Vector3.one;
        tra.anchoredPosition = new Vector2(-70f, -185f); // setting position, will be on center
        tra.sizeDelta = new Vector2(-460, -865); // custom size
    }
}
