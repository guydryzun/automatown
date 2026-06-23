using UnityEngine;

public class buttonManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject mainUI, ecaUI, golUI, llUI;
    [SerializeField] private GameObject ecaMaker, golMaker, llMaker;

    public void openEcaUi ()
    {
        ecaUI.SetActive(true);
        mainUI.SetActive(false);
    }

    public void runEca ()
    {
        ecaUI.SetActive(false);
        ecaMaker.SetActive(true);
    }

    public void checkRuleEca (string str)
    {
        if (!int.TryParse(str, out int n) || n < 0 || n > 255)
        {
            Debug.Log("Invalid input for ECA rule. Please enter a number between 0 and 255.");
        }
        else ecaMaker.GetComponent<makerScript>().r = n;
    }

    public void checkLengthEca (string str)
    {
        if (!int.TryParse(str, out int n) || n < 5)
        {
            Debug.Log("Invalid input for ECA length. Please enter an integer greater than or equal to 5.");
        }
        else ecaMaker.GetComponent<makerScript>().len = n;
    }

    public void randomizeEcaStart ()
    {
        ecaMaker.GetComponent<makerScript>().start = -1;
    }

    public void wrappingEca (bool val)
    {
        ecaMaker.GetComponent<makerScript>().edgeWrapping = val;
    }

    public void runEcaExample1 ()
    {
        ecaMaker.GetComponent<makerScript>().r = 126;
        ecaMaker.GetComponent<makerScript>().len = 300;
        ecaMaker.GetComponent<makerScript>().start = 150;
        runEca();
    }

    public void runEcaExample2 ()
    {
        ecaMaker.GetComponent<makerScript>().r = 110;
        ecaMaker.GetComponent<makerScript>().len = 300;
        ecaMaker.GetComponent<makerScript>().start = 297;
        runEca();
    }

    public void runEcaExample3 ()
    {
        ecaMaker.GetComponent<makerScript>().r = 57;
        ecaMaker.GetComponent<makerScript>().len = 300;
        ecaMaker.GetComponent<makerScript>().start = 150;
        runEca();
    }

    public void runEcaExample4 ()
    {
        ecaMaker.GetComponent<makerScript>().r = 169;
        ecaMaker.GetComponent<makerScript>().len = 300;
        ecaMaker.GetComponent<makerScript>().start = 297;
        runEca();
    }

    public void openGolUi ()
    {
        golUI.SetActive(true);
        mainUI.SetActive(false);
    }

    public void runGol ()
    {
        golUI.SetActive(false);
        golMaker.SetActive(true);
    }

    public void checkLengthGol (string str)
    {
        if (!int.TryParse(str, out int n) || n < 5)
        {
            Debug.Log("Invalid input for GOL length. Please enter an integer greater than or equal to 5.");
        }
        else golMaker.GetComponent<golMakerScript>().len = n;
    }

    public void runGolExample1 ()
    {
        golMaker.GetComponent<golMakerScript>().len = 100;
        int[][] exampleWorld = new int[100][];
        for (int i = 0; i < 100; i++) exampleWorld[i] = new int[100];
        exampleWorld[75][25] = 1;
        exampleWorld[75][24] = 1;
        exampleWorld[74][25] = 1;
        exampleWorld[74][24] = 1;
        exampleWorld[64][22] = 1;
        exampleWorld[64][23] = 1;
        exampleWorld[64][27] = 1;
        exampleWorld[64][28] = 1;
        exampleWorld[62][23] = 1;
        exampleWorld[62][27] = 1;
        exampleWorld[61][24] = 1;
        exampleWorld[61][25] = 1;
        exampleWorld[61][26] = 1;
        exampleWorld[60][24] = 1;
        exampleWorld[60][25] = 1;
        exampleWorld[60][26] = 1;
        exampleWorld[57][27] = 1;
        exampleWorld[56][26] = 1;
        exampleWorld[56][27] = 1;
        exampleWorld[56][28] = 1;
        exampleWorld[55][25] = 1;
        exampleWorld[55][29] = 1;
        exampleWorld[54][27] = 1;
        exampleWorld[53][24] = 1;
        exampleWorld[53][30] = 1;
        exampleWorld[52][24] = 1;
        exampleWorld[52][30] = 1;
        exampleWorld[51][25] = 1;
        exampleWorld[51][29] = 1;
        exampleWorld[50][26] = 1;
        exampleWorld[50][27] = 1;
        exampleWorld[50][28] = 1;
        exampleWorld[41][26] = 1;
        exampleWorld[41][27] = 1;
        exampleWorld[40][26] = 1;
        exampleWorld[40][27] = 1;
        golMaker.GetComponent<golMakerScript>().world = exampleWorld;
        runGol();
    }

    public void openLlUi ()
    {
        llUI.SetActive(true);
        mainUI.SetActive(false);
    }

    public void runLl ()
    {
        llUI.SetActive(false);
        llMaker.SetActive(true);
    }

    public void addB0LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(0);
        else llMaker.GetComponent<llMakerScript>().born.Remove(0);
    }

    public void addB1LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(1);
        else llMaker.GetComponent<llMakerScript>().born.Remove(1);
    }

    public void addB2LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(2);
        else llMaker.GetComponent<llMakerScript>().born.Remove(2);
    }

    public void addB3LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(3);
        else llMaker.GetComponent<llMakerScript>().born.Remove(3);
    }

    public void addB4LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(4);
        else llMaker.GetComponent<llMakerScript>().born.Remove(4);
    }

    public void addB5LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(5);
        else llMaker.GetComponent<llMakerScript>().born.Remove(5);
    }

    public void addB6LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(6);
        else llMaker.GetComponent<llMakerScript>().born.Remove(6);
    }

    public void addB7LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(7);
        else llMaker.GetComponent<llMakerScript>().born.Remove(7);
    }

    public void addB8LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().born.Add(8);
        else llMaker.GetComponent<llMakerScript>().born.Remove(8);
    }

    public void addS0LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(0);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(0);
    }

    public void addS1LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(1);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(1);
    }

    public void addS2LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(2);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(2);
    }

    public void addS3LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(3);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(3);
    }

    public void addS4LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(4);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(4);
    }

    public void addS5LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(5);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(5);
    }

    public void addS6LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(6);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(6);
    }

    public void addS7LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(7);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(7);
    }

    public void addS8LL (bool val)
    {
        if (val) llMaker.GetComponent<llMakerScript>().survive.Add(8);
        else llMaker.GetComponent<llMakerScript>().survive.Remove(8);
    }

    public void runLlExample1 ()
    {
        llMaker.GetComponent<llMakerScript>().len = 100;
        llMaker.GetComponent<llMakerScript>().born.Add(1);
        llMaker.GetComponent<llMakerScript>().born.Add(3);
        llMaker.GetComponent<llMakerScript>().born.Add(5);
        llMaker.GetComponent<llMakerScript>().born.Add(7);
        llMaker.GetComponent<llMakerScript>().survive.Add(1);
        llMaker.GetComponent<llMakerScript>().survive.Add(3);
        llMaker.GetComponent<llMakerScript>().survive.Add(5);
        llMaker.GetComponent<llMakerScript>().survive.Add(7);
        runLl();
    }

    public void runLlExample2 ()
    {
        llMaker.GetComponent<llMakerScript>().len = 100;
        llMaker.GetComponent<llMakerScript>().born.Add(2);
        runLl();
    }

    public void runLlExample3 ()
    {
        llMaker.GetComponent<llMakerScript>().len = 100;
        llMaker.GetComponent<llMakerScript>().born.Add(3);
        llMaker.GetComponent<llMakerScript>().survive.Add(0);
        llMaker.GetComponent<llMakerScript>().survive.Add(1);
        llMaker.GetComponent<llMakerScript>().survive.Add(2);
        llMaker.GetComponent<llMakerScript>().survive.Add(3);
        llMaker.GetComponent<llMakerScript>().survive.Add(4);
        llMaker.GetComponent<llMakerScript>().survive.Add(5);
        llMaker.GetComponent<llMakerScript>().survive.Add(6);
        llMaker.GetComponent<llMakerScript>().survive.Add(7);
        llMaker.GetComponent<llMakerScript>().survive.Add(8);
        runLl();
    }
}
