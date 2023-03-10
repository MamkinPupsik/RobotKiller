using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float mouseX;
    private float mouseY;

    public bool CameraMove = true;

    float xRotation = 0f;

    [Header("???????????????? ????")]
    public float sensitivityMouse = 2f;

    [Header("??? ?????")]
    public Transform Player;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (CameraMove)
        {
            mouseX = Input.GetAxis("Mouse X") * sensitivityMouse;
            mouseY = Input.GetAxis("Mouse Y") * sensitivityMouse;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -60f, 60f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            transform.Rotate(-mouseY * new Vector3(1, 0, 0) * Time.deltaTime);

            Player.Rotate(mouseX * new Vector3(0, 1, 0));
        }
       
    }
}