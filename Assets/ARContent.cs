using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARContent : MonoBehaviour
{
    public Animator AR;
    // Start is called before the first frame update
    public void Scene2()
    {
        AR.SetTrigger("Next");
        AR.ResetTrigger("Back");
    }
    public void Scene3()
    {
        AR.ResetTrigger("Next");
        AR.ResetTrigger("Back");
        AR.SetTrigger("Next2");
        AR.ResetTrigger("Back");
    }
    public void BacktoS1()
    {
        AR.SetTrigger("Back");
        AR.ResetTrigger("Next");
        AR.ResetTrigger("Next2");
        AR.ResetTrigger("Back2");
    }
    public void BacktoS2()
    {
        AR.SetTrigger("Back2");
        AR.ResetTrigger("Next2");
        AR.ResetTrigger("Back");
        AR.ResetTrigger("Next");
    }

    public void Scene4()
    {
        AR.SetTrigger("Next3");
        AR.ResetTrigger("Back3");
        AR.ResetTrigger("Back2");
        AR.ResetTrigger("Next2");
        AR.ResetTrigger("Back");
        AR.ResetTrigger("Next");
    }
    public void Scene0()
    {
        AR.SetTrigger("Next00");
    }

    public void Replay()
    {
        AR.SetTrigger("Replay");
        AR.ResetTrigger("Back3");
        AR.ResetTrigger("Back2");
        AR.ResetTrigger("Next2");
        AR.ResetTrigger("Back");
        AR.ResetTrigger("Next");
        AR.ResetTrigger("Next00");
    }
}
