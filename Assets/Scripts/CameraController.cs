using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Calculated once before game starts
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // called every frame
        // only matching position, not the rotation of the sphere
        // cannot control order in which Update() is called in all scripts, 
        // so this one may run before other Update() functions in other scripts are called
        // that may change the player's position, e.g. the physics system,
        // so we changed Update() to LateUpdate()
        // LateUpdate() runs every frame, but runs after all other Update()s are done
        transform.position = player.transform.position + offset;
    }
}
