using UnityEngine;

public class buttonManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject mainUI, ecaUI;
    [SerializeField] private GameObject maker;

    public void openEcaUi ()
    {
        ecaUI.SetActive(true);
        mainUI.SetActive(false);
    }

    public void runEca ()
    {
        ecaUI.SetActive(false);
        maker.SetActive(true);
    }

    public void checkRuleEca (string str)
    {
        if (!int.TryParse(str, out int n) || n < 0 || n > 255)
        {
            Debug.Log("Invalid input for ECA rule. Please enter a number between 0 and 255.");
        }
        else maker.GetComponent<makerScript>().r = n;
    }

    public void checkLengthEca (string str)
    {
        if (!int.TryParse(str, out int n) || n < 5)
        {
            Debug.Log("Invalid input for ECA length. Please enter an integer greater than or equal to 5.");
        }
        else maker.GetComponent<makerScript>().len = n;
    }

    public void randomizeEcaStart ()
    {
        maker.GetComponent<makerScript>().start = -1;
    }

    public void wrappingEca (bool val)
    {
        maker.GetComponent<makerScript>().edgeWrapping = val;
    }

    public void runEcaExample1 ()
    {
        maker.GetComponent<makerScript>().r = 126;
        maker.GetComponent<makerScript>().len = 300;
        maker.GetComponent<makerScript>().start = 150;
        runEca();
    }

    public void runEcaExample2 ()
    {
        maker.GetComponent<makerScript>().r = 110;
        maker.GetComponent<makerScript>().len = 300;
        maker.GetComponent<makerScript>().start = 297;
        runEca();
    }

    public void runEcaExample3 ()
    {
        maker.GetComponent<makerScript>().r = 57;
        maker.GetComponent<makerScript>().len = 300;
        maker.GetComponent<makerScript>().start = 150;
        runEca();
    }

    public void runEcaExample4 ()
    {
        maker.GetComponent<makerScript>().r = 169;
        maker.GetComponent<makerScript>().len = 300;
        maker.GetComponent<makerScript>().start = 297;
        runEca();
    }
}
