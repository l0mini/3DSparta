using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpBox : MonoBehaviour
{
    public int jumpPower;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Rigidbody rigidbody))
        {
            Vector3 force = Vector3.up * jumpPower; 
            rigidbody.velocity = Vector3.zero; 
            rigidbody.AddForce(force, ForceMode.Impulse); 
        }
    }
}
