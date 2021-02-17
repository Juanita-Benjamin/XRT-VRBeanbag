using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{

    public GameObject[] environments;

    //public int environIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeEnviron(float index)
    {
        for (int i = 0; i < environments.Length; i++)
        {
            if (i != index)
            {
                environments[i].gameObject.SetActive(false);
            }
            else
            {
                environments[i].gameObject.SetActive(true);
            }
        }
    }
}
