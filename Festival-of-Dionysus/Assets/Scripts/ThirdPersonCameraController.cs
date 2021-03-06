using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public float RotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;


    void Start()
	{
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}

    void LateUpdate()
	{
        CamControl();
	}

    void CamControl()
	{
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, 0, 30);

        transform.LookAt(Target);

        if(Input.GetKey(KeyCode.LeftShift))
		{
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
		}else
		{
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            Player.rotation = Quaternion.Euler(0, mouseX, 0);
        }

        
	}
}

