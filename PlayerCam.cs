public classn PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;


    public transform orientation;

    float xRotation;
    float yRotation;


    privatevoid Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    float  mouseX=iomn
    float mouseY=Input.GetAxis("Mouse Y")*sensY*Time.deltaTime;
     
