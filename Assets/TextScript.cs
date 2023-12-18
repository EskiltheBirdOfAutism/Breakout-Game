using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TMP_Text text;
    public int number = 0;

    // Update is called once per frame
    public void Update()
    {
        text.text = number.ToString();

        if (number >= 21) text.text = "YOU WIN";
    }
}
