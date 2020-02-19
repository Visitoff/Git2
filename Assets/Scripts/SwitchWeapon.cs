using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SwitchWeapon : MonoBehaviour
{
    public GameObject avatar1, avatar2;
    int wichAvatarIsOn = 1; 
    public SteamVR_Action_Boolean TriggerClick;
    public SteamVR_Input_Sources inputSource;
    private SteamVR_TrackedObject trackedObj;
    void Start()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);

    }
    private void Update()
    {
        if (SteamVR_Actions._default.GrabGrip.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            Debug.Log("123");
            SwitchAvatar();
        }
    }



    public void SwitchAvatar()
    {
        {
            switch (wichAvatarIsOn)
            {
                case 1:
                    wichAvatarIsOn = 2;
                    avatar1.gameObject.SetActive(false);
                    avatar2.gameObject.SetActive(true);
                    break;

                case 2:
                    wichAvatarIsOn = 1;
                    avatar1.gameObject.SetActive(true);
                    avatar2.gameObject.SetActive(false);
                    break;

            }
        }
    }
}
