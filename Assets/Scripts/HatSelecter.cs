using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatSelecter : MonoBehaviour
{
    [SerializeField] List<GameObject> hatObjectPool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectHat(int x)
    {
        if (x == 0)
        {
            for (int i = 0; i < hatObjectPool.Count; i++)
            {
                hatObjectPool[i].SetActive(false);
            }
            return;
        }

        for (int i = 0; i < hatObjectPool.Count; i++)
        {
            if (i == x-1)
            {
                hatObjectPool[i].SetActive(true);
            }
            else
            {
                hatObjectPool[i].SetActive(false);
            }
        }
    }
}
