using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonn : MonoBehaviour
{
    [SerializeField]
    private GameObject Cube;

    public void OnMouseDown()
    {
        Cube.GetComponent<Renderer>().material.color = Color.green;
    }

    public void OnMouseUp()
    {
        Cube.GetComponent<Renderer>().material.color = Color.red;
    }

}
