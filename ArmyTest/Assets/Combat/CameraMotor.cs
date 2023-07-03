using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Get the camera's forward and right vectors
        Vector3 cameraForward = Camera.main.transform.forward;
        Vector3 cameraRight = Camera.main.transform.right;

        // Set the y component of the vectors to 0 to ignore vertical movement
        cameraForward.y = 0f;
        cameraRight.y = 0f;

        // Normalize the vectors to maintain consistent speed regardless of camera rotation
        cameraForward.Normalize();
        cameraRight.Normalize();

        // Calculate the movement vector based on input and camera orientation
        Vector3 movement = cameraForward * moveVertical + cameraRight * moveHorizontal;

        // Apply the movement to the camera's position
        transform.Translate(speed * Time.deltaTime * movement, Space.World);
    }
}
