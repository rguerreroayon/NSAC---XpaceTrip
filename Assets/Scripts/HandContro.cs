using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;



public class HandContro : MonoBehaviour
{
    [SerializeField]
    CapsuleHand capsuleHand;

    Hand hand;

    [SerializeField]
    GameObject menuPlane;

    [SerializeField]
    Vector3 menuPlanePositionInPalm;

    void Update()
    {
        if (capsuleHand && gameObject.activeSelf)
        {
            if (hand == null)
            {
                hand = capsuleHand.GetLeapHand();
            }
            else
            {
                //menuPlane.transform.position = hand.PalmPosition.ToVector3();

                menuPlane.transform.SetPositionAndRotation(hand.PalmPosition.ToVector3() + menuPlanePositionInPalm, hand.Rotation.ToQuaternion());
            }
        }
    }
}
