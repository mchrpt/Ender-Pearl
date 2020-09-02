using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Contact : MonoBehaviour
{
    public static event Action<bool> teleport = delegate {};
    public Boolean tp;
    // Start is called before the first frame update
    void Start()
    {
        tp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
       tp = true;
       teleport(tp);
       Destroy(gameObject);
    }
}
