using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L15 : MonoBehaviour
{
    [SerializeField] private int _healthDefault = 100;

    public int Health { get; private set; }

    public float Normalized => (float)Health / _healthDefault;

    private void Awake()
    {
        Health = _healthDefault;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            H();
    }

    private void H()
    {
        Health -= 5;
    }

}
