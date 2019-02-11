using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public void Update()
    {
        int count = GameObject.FindGameObjectWithTag("Item").Length;
    }
}
