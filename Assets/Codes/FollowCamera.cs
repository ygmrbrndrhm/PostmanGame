using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject ToFollow;
    void LateUpdate()
    {
        transform.position = ToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
