using UnityEngine;
using UnityEngine.UI;

public class CheckMark : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    void OnEnable ()
    {
        GameObject gm = GameObject.Find("GameManager");

        if (gm.GetComponent<GameManager>().hasItem1 == true)
        {
            var tempColor = image1.color;
            tempColor.a = 255f;
            image1.color = tempColor;
        }

        if (gm.GetComponent<GameManager>().hasItem2 == true)
        {
            var tempColor = image2.color;
            tempColor.a = 255f;
            image2.color = tempColor;
        }

        if (gm.GetComponent<GameManager>().hasItem3 == true)
        {
            var tempColor = image3.color;
            tempColor.a = 255f;
            image3.color = tempColor;
        }

        if (gm.GetComponent<GameManager>().hasItem4 == true)
        {
            var tempColor = image4.color;
            tempColor.a = 255f;
            image4.color = tempColor;
        }
    }
}
