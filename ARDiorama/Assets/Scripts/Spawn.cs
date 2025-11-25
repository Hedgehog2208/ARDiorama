using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pref;


    void Start()
    {
        EarthSpawn();
    }

    private void EarthSpawn()
    {
        for (float i = -4.5f; i < i+10; i++)
        {
            for (float j = -4.5f;  j < j+10; j++)
            {
                Instantiate(pref, new Vector3(i,0,j), Quaternion.identity);
            }
        }
    }
}
