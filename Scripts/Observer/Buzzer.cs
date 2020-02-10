using UnityEngine;
public class Buzzer : MonoBehaviour
{
    void OnEnable()
    {
        ObserverTimer.OnTimerStarted += PlayStartBuzzer; ObserverTimer.OnTimerEnded += PlayEndBuzzer;
    }
    void OnDisable()
    {
        ObserverTimer.OnTimerStarted -= PlayStartBuzzer; ObserverTimer.OnTimerEnded -= PlayEndBuzzer;
    }
    void PlayStartBuzzer()
    {
        Debug.Log("[BUZZER] : Play start buzzer!");
    }
    void PlayEndBuzzer()
    {
        Debug.Log("[BUZZER] : Play end buzzer!");
    }
}