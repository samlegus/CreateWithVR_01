using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform hourHand, minuteHand, secondHand;
    [SerializeField] float hour, minute, second;

    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        second = System.DateTime.Now.Second;

        hourHand.localRotation = Quaternion.Euler(hour / 12f * 360f, 0f, 0f);
        minuteHand.localRotation = Quaternion.Euler(minute / 60f * 360f, 0f, 0f);
        secondHand.localRotation = Quaternion.Euler(second / 60f * 360f, 0f, 0f);
    }
}
