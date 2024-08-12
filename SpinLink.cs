using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinLink : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    private void Update()
    {
        this.transform.Rotate(rotation * 1 * Time.deltaTime);
    }
}
