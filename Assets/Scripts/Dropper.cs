using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    [SerializeField] float dropTime = 3f;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > dropTime)
        {
            rigidBody.useGravity = true;
            meshRenderer.enabled = true;
            Debug.Log("DROP!!");
        }
    }
}
