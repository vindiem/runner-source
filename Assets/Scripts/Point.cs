using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject[] spinner;

    private void Start()
    {
        int rand = Random.Range(0, spinner.Length);
        Instantiate(spinner[rand], transform.position, Quaternion.identity);
    }
}
