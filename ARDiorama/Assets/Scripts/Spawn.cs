using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Earth;
    public GameObject House1;

    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        EarthSpawn();
    }

	private void Update()
	{
		
	}

	private void EarthSpawn()
    {
        float firstI = -4.5f;
        float firstY = -4.5f;

        for (float i = firstI; i < firstI + 10; i++)
        {
            for (float j = firstY; j < firstY + 10; j++)
            {
                Instantiate(Earth, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }

    private void SpawnRay()
    {
        
    }
}
