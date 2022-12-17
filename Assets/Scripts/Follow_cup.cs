using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_cup : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 target_offset;
    void Start()
    {
        target_offset=transform.position-target.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + target_offset, .125f);
    }
}
