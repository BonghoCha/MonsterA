using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    [SerializeField] private GameObject[] Objects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void ObjectsOff()
    {
        foreach (GameObject obj in Objects)
        {
            obj.SetActive(false);
        }
    }

    private void ObjectOn(int n)
    {
        ObjectsOff();

        Objects[n].SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ObjectOn(0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ObjectOn(1);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ObjectOn(2);
        }
    }
}
