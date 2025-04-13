using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation; // the information of where the player's looking(���ޤW�U)
    public Transform camHolder;
    public Transform player;

    float xRotation;
    float yRotation;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // �����w�b�ù������A�L�k���ʦ����i�����ƹ��W�q��J
        Cursor.visible = false;
    }

    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // ����W�U��ʹw���ϤH��

        //rotate cam and orientation
        camHolder.rotation = Quaternion.Euler(xRotation, yRotation, 0); // ���Φb�Ĥ@�H�ٵ����۾�
        orientation.rotation = Quaternion.Euler(0, yRotation, 0); // orientation�ȰO�����a�¦V��T
        player.transform.rotation = orientation.rotation; // �갵���a�¦V
    }

    public void DoFov(float endValue)
    {
        // ���۾��� FOV �b 0.25 �� ���Ʀa�ܤƨ� endValue
        GetComponent<Camera>().DOFieldOfView(endValue, 0.25f);
    }

    public void DoTilt(float zTilt)
    {
        transform.DOLocalRotate(new Vector3(0, 0, zTilt), 0.25f);
    }
}
