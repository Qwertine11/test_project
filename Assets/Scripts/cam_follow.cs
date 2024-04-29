using System.Collections;
using UnityEngine;


public class follow_ch : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 pos;

    void Update()
    {
        transform.position = player.position + pos;

    }
    
}
