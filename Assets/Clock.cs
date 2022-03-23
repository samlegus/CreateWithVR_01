using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform hourHand, minuteHand, secondHand;
    [SerializeField] float hour, minute, second;

    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        second = System.DateTime.Now.Second;

        hourHand.localRotation = Quaternion.Euler(hour / 12 * 360, 0, 0);
        minuteHand.localRotation = Quaternion.Euler(minute / 60 * 360, 0, 0);
        secondHand.localRotation = Quaternion.Euler(second / 60 * 360, 0, 0);
    }
}
