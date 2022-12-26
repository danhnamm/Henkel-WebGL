using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARManager : MonoBehaviour
{
    public GameObject Grid;
    public GameObject text;
    public GameObject AR;
    void Start()
    {
        AR.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Grid.SetActive(false);
            text.SetActive(false);
            AR.SetActive(true);
        }
    }
}   