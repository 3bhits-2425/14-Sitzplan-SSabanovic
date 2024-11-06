using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject myParent;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            //Instantiate(prefab, myParent.transform);
            GameObject obj = Instantiate(prefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
