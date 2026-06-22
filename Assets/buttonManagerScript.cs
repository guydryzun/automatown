using UnityEngine;

public class buttonManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject mainUI, ecaUI, golUI;
    [SerializeField] private GameObject ecaMaker, golMaker;

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
}
