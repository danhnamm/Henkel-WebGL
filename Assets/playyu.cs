using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playyu : MonoBehaviour
{
    public Animator test;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void set()
    {
        test.SetTrigger("Info");
        test.ResetTrigger("Back");
    }

    public void Back()
    {
        test.SetTrigger("Back");
        test.ResetTrigger("Info");
        test.ResetTrigger("Map");
        test.ResetTrigger("Check");

    }

    public void Map()
    {
        test.SetTrigger("Map");
        test.ResetTrigger("Back");
    }

    public void Checkin()
    {
        test.SetTrigger("Check");
        test.ResetTrigger("Back");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
