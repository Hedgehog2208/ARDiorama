using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Spawn spawn;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        spawn.EarthSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        spawn.SpawnRay(cam);
    }
}