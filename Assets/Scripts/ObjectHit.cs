using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public Rigidbody rb;
    public Collision cl;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.grey;
            gameObject.tag = "Hit";
        }
    }
}
