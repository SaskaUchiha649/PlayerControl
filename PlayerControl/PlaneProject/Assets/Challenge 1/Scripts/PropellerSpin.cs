using UnityEngine;
using UnityEngine.UIElements;

public class PropellerSpin : MonoBehaviour
{
    private float rotationSpeed = 20000000000000000.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
