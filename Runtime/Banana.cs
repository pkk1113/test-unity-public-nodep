using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    private Rigidbody m_rigidbody;

    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (m_rigidbody == null)
        {
            return;
        }

        StartCoroutine(StartAnimation());
    }

    private IEnumerator StartAnimation()
    {
        var dir = Random.onUnitSphere;
        dir.y = 0;
        dir = dir.normalized * 10f;

        m_rigidbody.AddForce(dir, ForceMode.Impulse);

        yield break;
    }
}
