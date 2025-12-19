using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Earth;
    public GameObject earthParent;
    public GameObject house1;

    private GameObject obj;

	public void EarthSpawn() // Спавним землю
    {
        float firstI = -4.5f;
        float firstY = -4.5f;

        for (float i = firstI; i < firstI + 10; i++)
        {
            for (float j = firstY; j < firstY + 10; j++)
            {
                Instantiate(Earth, new Vector3(i, 0, j), Quaternion.identity, earthParent.transform);
            }
        }
    }

    public void SpawnRay(Camera cam) // Создаем луч
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
            SpawnTown(hit);
        }
    }

    private void SpawnTown(RaycastHit hit) // Спавним и редактируем строения
    {
        if (hit.collider.tag == "Earth")
        {
            obj = Instantiate(house1, hit.transform.position, Quaternion.identity);
            obj.transform.localScale = new Vector3(1, 0.25f, 1);
            obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.localScale.y/2, obj.transform.position.z);
            return;
        }
        if (hit.collider.tag == "House1")
        {
            hit.transform.localScale = new Vector3(1, 0.75f, 1);
            hit.collider.tag = "House2";
			obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.localScale.y / 2, obj.transform.position.z);
			return;
		}
        if (hit.collider.tag == "House2")
        {
			hit.transform.localScale = new Vector3(1, 1.25f, 1);
			hit.collider.tag = "House3";
            obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.localScale.y / 2, obj.transform.position.z);
			return;
		}
    }
}
