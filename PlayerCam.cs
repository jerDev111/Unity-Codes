public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;


    public transform orientation;

    float xRotation;
    float yRotation;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        
         float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * SensX;
         float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * SensY;

         yRotation += mouseX;
         xRotation -= mouseY;
    }
}
   
