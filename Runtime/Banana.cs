using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Banana!!");
    }
}
