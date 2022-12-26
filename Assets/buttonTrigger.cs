using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonTrigger : MonoBehaviour
{public Animator test;
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
        test.ResetTrigger("Agenda");

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

    public void Agen()
    {
        test.SetTrigger("Agenda");
        test.ResetTrigger("Back");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
