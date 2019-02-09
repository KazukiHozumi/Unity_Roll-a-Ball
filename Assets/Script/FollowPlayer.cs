using UnityEngine;
using System.Collections;


public class FollowPlayer : MonoBehaviour
{
    public Transform target;

    void Update() 
    {
        GetComponent<Transform>().position = target.position;        
    }

}
