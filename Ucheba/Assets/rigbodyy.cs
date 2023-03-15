using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rigbodyy : MonoBehaviour
{
    [SerializeField]
    private GameObject Cube;

    [SerializeField]
    private Text Hpp;

    bool oncol = false;
    public int hp = 100;

    private void OnCollisionEnter(Collision collision)
    {
        oncol = true;
    }

    void Update()
    {
        if (oncol = true)
        {
            hp -= 1;
            //GetComponent<TextMesh>().text = hp;
            Hpp.text = hp.ToString();
        }
        
    }
}
