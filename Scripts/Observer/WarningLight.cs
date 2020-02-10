using UnityEngine;
public class WarningLight : MonoBehaviour
{
    public void OnEnable()
    {
        ObserverTimer.OnHalfTime += BlinkLight;
    }
    public void OnDisable()
    {
        ObserverTimer.OnHalfTime -= BlinkLight;
    }
    void BlinkLight()
    {
        Debug.Log("[WARNING LIGHT] : It's half-time, blinking the warning light!");
    }
}