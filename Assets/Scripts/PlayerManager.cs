using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerManager : MonoBehaviour
{
    public int startStrength = 20;
    public int currentStrength;

    public StrengthBar strengthBar;
    void Start()
    {
        currentStrength = startStrength;
        strengthBar.SetMaxStrength(currentStrength);

        Debug.Log(currentStrength);
    }

    public void GainStrength(int strength)
    {
        currentStrength += strength;

        strengthBar.SetStrength(currentStrength);
    }
}
