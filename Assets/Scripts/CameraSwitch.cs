using System.Collections;
using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public string playerTag = "Player";

    public GameObject CameraSwitchTo;
    public GameObject CameraSwitchBack;

    public GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            CameraSwitchBack.GetComponent<CinemachineCamera>().enabled = false;
            CameraSwitchTo.GetComponent<CinemachineCamera>().enabled = true;

            Player.GetComponent<PlayerControllerV2>().cameraTransform = CameraSwitchTo.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            CameraSwitchBack.GetComponent<CinemachineCamera>().enabled = true;
            CameraSwitchTo.GetComponent<CinemachineCamera>().enabled = false;

            Player.GetComponent<PlayerControllerV2>().cameraTransform = CameraSwitchBack.transform;
        }
    }
}
