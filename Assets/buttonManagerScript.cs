using UnityEngine;

public class buttonManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject mainUI, ecaUI;
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

    public void runGol ()
    {
        mainUI.SetActive(false);
        golMaker.SetActive(true);
    }
}
