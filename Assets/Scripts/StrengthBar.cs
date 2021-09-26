using UnityEngine;
using UnityEngine.UI;

public class StrengthBar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxStrength(int strength)
    {
        //slider.maxValue = strength;
        slider.value = strength;
    }
    
    public void SetStrength(int strength)
    {
        slider.value = strength;
    }
}
