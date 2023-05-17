public class CameraLock MonoBehavior

public float mouseSensitivity = 80f;
//You can change the sensitivity from the Unity inspector
public Transform playerBody
//Here you have to assign your player
float xRotation = 0;

Void Start()
{
    Cursor.lockState = Cursor.LockStateMode.Locked;
}

Void Update()
{
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    xRotation += mouseY;

}