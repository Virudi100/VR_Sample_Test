using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manivelle : MonoBehaviour
{
    [SerializeField] private GameObject cockpit;
    private float speed = 0.7f;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("ZDFront"))
        {
            cockpit.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if(other.gameObject.CompareTag("ZDBack"))
        {
            cockpit.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
