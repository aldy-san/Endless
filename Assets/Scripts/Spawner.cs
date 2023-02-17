using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> ObsParents;
    public Transform target;
    void Update()
    {
        transform.position = new Vector3(0, 0, target.position.z + 49);
    }

    public void Spawn()
    {
        GameObject spawn = Instantiate(ObsParents[0]);
        spawn.transform.position = transform.position;
    }
}
