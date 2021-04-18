using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetChangeLocation : MonoBehaviour
{
    public int min, max;

    public void ChangePlace()
    {
        transform.position = new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
    }
}
