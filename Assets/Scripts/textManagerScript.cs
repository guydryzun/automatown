using UnityEngine;

public class textManagerScript : MonoBehaviour
{
    public int currentTextIndex = 0;
    public GameObject[] texts;
    public GameObject nextButton, lastButton;
    public int scene;
    public int[] lengths;

    public void NextText()
    {
        if (currentTextIndex < lengths[scene] - 1)
        {
            texts[currentTextIndex].SetActive(false);
            currentTextIndex++;
            texts[currentTextIndex].SetActive(true);
        }
        if (currentTextIndex == lengths[scene] - 1) nextButton.SetActive(false);
        if (lastButton.activeSelf == false) lastButton.SetActive(true);
    }

    public void lastText()
    {
        if (currentTextIndex >= lengths[scene + 1])
        {
            texts[currentTextIndex].SetActive(false);
            currentTextIndex--;
            texts[currentTextIndex].SetActive(true);
        }
        if (currentTextIndex == lengths[scene + 1]) lastButton.SetActive(false);
        if (nextButton.activeSelf == false) nextButton.SetActive(true);
    }
}
