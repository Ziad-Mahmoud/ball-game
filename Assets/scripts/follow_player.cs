
using UnityEngine;

public class follow_player : MonoBehaviour
{ 
    public Transform player ;
    public Vector3 offset;
    void Update()
    {
       transform.position = player.position + offset;  
    }
}
