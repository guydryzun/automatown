using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject mainUI, ecaUI, ecaRUI, ecaMUI, golUI, golRUI, llUI, wwUi, wwRUI, wwMUi;
    [SerializeField] private GameObject ecaMaker, golMaker, llMaker, wwMaker;
    [SerializeField] private GameObject textManager;
    private string running = "";

    public void openEcaUi ()
    {
        ecaUI.SetActive(true);
        mainUI.SetActive(false);
    }

    public void runEca ()
    {
        ecaUI.SetActive(false);
        ecaRUI.SetActive(true);
        ecaMaker.SetActive(true);
        cam.transform.position = new Vector3 (0, 1.3f, -10);
        running = "eca";
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
        golRUI.SetActive(true);
        golMaker.SetActive(true);
        running = "gol";
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
        golRUI.SetActive(true);
        llMaker.SetActive(true);
        running = "ll";
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

    public void add11Ll (bool val)
    {
        int x = 0, y = 0;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add21Ll (bool val)
    {
        int x = 1, y = 0;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add31Ll (bool val)
    {
        int x = 2, y = 0;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add41Ll (bool val)
    {
        int x = 3, y = 0;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add51Ll (bool val)
    {
        int x = 4, y = 0;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add12Ll (bool val)
    {
        int x = 0, y = 1;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add22Ll (bool val)
    {
        int x = 1, y = 1;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add32Ll (bool val)
    {
        int x = 2, y = 1;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add42Ll (bool val)
    {
        int x = 3, y = 1;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add52Ll (bool val)
    {
        int x = 4, y = 1;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add13Ll (bool val)
    {
        int x = 0, y = 2;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add23Ll (bool val)
    {
        int x = 1, y = 2;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add43Ll (bool val)
    {
        int x = 3, y = 2;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add53Ll (bool val)
    {
        int x = 4, y = 2;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add14Ll (bool val)
    {
        int x = 0, y = 3;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add24Ll (bool val)
    {
        int x = 1, y = 3;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add34Ll (bool val)
    {
        int x = 2, y = 3;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add44Ll (bool val)
    {
        int x = 3, y = 3;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add54Ll (bool val)
    {
        int x = 4, y = 3;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

        public void add15Ll (bool val)
    {
        int x = 0, y = 4;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add25Ll (bool val)
    {
        int x = 1, y = 4;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add35Ll (bool val)
    {
        int x = 2, y = 4;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add45Ll (bool val)
    {
        int x = 3, y = 4;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public void add55Ll (bool val)
    {
        int x = 4, y = 4;
        if (val)
        {
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(x);
            llMaker.GetComponent<llMakerScript>().neighbourhoodList.Add(y);
        } 
        else {
            for (int i = 0; i < llMaker.GetComponent<llMakerScript>().neighbourhoodList.Count; i += 2)
            {
                if (llMaker.GetComponent<llMakerScript>().neighbourhoodList[i] == x && llMaker.GetComponent<llMakerScript>().neighbourhoodList[i + 1] == y)
                {
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    llMaker.GetComponent<llMakerScript>().neighbourhoodList.RemoveAt(i);
                    break;
                }
            }
        }
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

    public void runLlExample3 ()
    {
        llMaker.GetComponent<llMakerScript>().len = 100;
        add22Ll(false);
        add42Ll(false);
        add24Ll(false);
        add44Ll(false);
        llMaker.GetComponent<llMakerScript>().born.Add(2);
        llMaker.GetComponent<llMakerScript>().survive.Add(2);
        llMaker.GetComponent<llMakerScript>().survive.Add(1);
        runLl();
    }

    public void runLlExample4 ()
    {
        llMaker.GetComponent<llMakerScript>().len = 100;
        add11Ll(true);
        add31Ll(true);
        add51Ll(true);
        add32Ll(false);
        add13Ll(true);
        add23Ll(false);
        add43Ll(false);
        add53Ll(true);
        add34Ll(false);
        add15Ll(true);
        add35Ll(true);
        add55Ll(true);
        llMaker.GetComponent<llMakerScript>().born.Add(3);
        llMaker.GetComponent<llMakerScript>().survive.Add(3);
        llMaker.GetComponent<llMakerScript>().survive.Add(2);
        llMaker.GetComponent<llMakerScript>().survive.Add(6);
        runLl();
    }

    public void openWWUi ()
    {
        wwUi.SetActive(true);
        mainUI.SetActive(false);
    }

    public void runWw ()
    {
        wwUi.SetActive(false);
        wwRUI.SetActive(true);
        wwMaker.SetActive(true);
        running = "ww";
    }

    public void checkLengthWw (string str)
    {
        if (!int.TryParse(str, out int n) || n < 5)
        {
            Debug.Log("Invalid input for WW length. Please enter an integer greater than or equal to 5.");
        }
        else wwMaker.GetComponent<wwMakerScript>().len = n;
    }

    public void setWW0 ()
    {
        wwMaker.GetComponent<wwMakerScript>().current = 0;
        wwRUI.transform.Find("underline").GetComponent<RectTransform>().anchoredPosition  = new Vector3(-400, 415, 0);
    }

    public void setWW1 ()
    {
        wwMaker.GetComponent<wwMakerScript>().current = 1;
        wwRUI.transform.Find("underline").GetComponent<RectTransform>().anchoredPosition  = new Vector3(-300, 415, 0);
    }

    public void setWW2 ()
    {
        wwMaker.GetComponent<wwMakerScript>().current = 2;
        wwRUI.transform.Find("underline").GetComponent<RectTransform>().anchoredPosition  = new Vector3(-200, 415, 0);
    }

    public void setWW3 ()
    {
        wwMaker.GetComponent<wwMakerScript>().current = 3;
       wwRUI.transform.Find("underline").GetComponent<RectTransform>().anchoredPosition  = new Vector3(-100, 415, 0);
    }

    public void runWWExample1 ()
    {
        wwMaker.GetComponent<wwMakerScript>().len = 100;
        int[][] exampleWorld = new int[100][];
        for (int i = 0; i < 100; i++) exampleWorld[i] = new int[100];
        exampleWorld[50][50] = 2;
        exampleWorld[50][46] = 1;
        exampleWorld[51][51] = 1;
        exampleWorld[51][49] = 3;
        exampleWorld[51][46] = 1;
        exampleWorld[52][51] = 1;
        exampleWorld[52][49] = 1;
        exampleWorld[52][46] = 1;
        exampleWorld[53][51] = 1;
        exampleWorld[53][49] = 1;
        exampleWorld[53][46] = 1;
        exampleWorld[54][51] = 1;
        exampleWorld[54][49] = 1;
        exampleWorld[54][46] = 1;
        exampleWorld[55][50] = 1;
        exampleWorld[55][46] = 1;
        exampleWorld[56][50] = 1;
        exampleWorld[56][46] = 1;
        exampleWorld[57][51] = 1;
        exampleWorld[57][50] = 1;
        exampleWorld[57][49] = 1;
        exampleWorld[57][47] = 1;
        exampleWorld[57][46] = 1;
        exampleWorld[57][45] = 1;
        exampleWorld[58][51] = 1;
        exampleWorld[58][49] = 1;
        exampleWorld[58][47] = 1;
        exampleWorld[58][45] = 1;
        exampleWorld[59][50] = 1;
        exampleWorld[59][46] = 1;
        exampleWorld[60][50] = 1;
        exampleWorld[60][46] = 2;
        exampleWorld[61][50] = 1;
        exampleWorld[61][47] = 1;
        exampleWorld[61][45] = 3;
        exampleWorld[62][50] = 1;
        exampleWorld[62][47] = 1;
        exampleWorld[62][45] = 1;
        exampleWorld[63][50] = 1;
        exampleWorld[63][47] = 1;
        exampleWorld[63][45] = 1;
        exampleWorld[64][50] = 1;
        exampleWorld[64][47] = 1;
        exampleWorld[64][45] = 1;
        exampleWorld[65][50] = 1;
        exampleWorld[65][46] = 1;
        wwMaker.GetComponent<wwMakerScript>().world = exampleWorld;
        runWw();
    }

    public void runWWExample2 ()
    {
        wwMaker.GetComponent<wwMakerScript>().len = 100;
        int[][] exampleWorld = new int[100][];
        for (int i = 0; i < 100; i++) exampleWorld[i] = new int[100];
        exampleWorld[52][50] = 2;
        exampleWorld[53][49] = 1;
        exampleWorld[53][51] = 3;
        exampleWorld[54][49] = 3;
        exampleWorld[54][51] = 1;
        exampleWorld[55][50] = 2;
        exampleWorld[56][50] = 1;
        exampleWorld[57][50] = 1;
        exampleWorld[58][49] = 1;
        exampleWorld[58][52] = 3;
        exampleWorld[58][53] = 1;
        exampleWorld[59][49] = 1;
        exampleWorld[59][51] = 2;
        exampleWorld[59][53] = 2;
        exampleWorld[60][50] = 1;
        exampleWorld[60][51] = 2;
        exampleWorld[60][52] = 3;
        exampleWorld[60][53] = 1;
        exampleWorld[61][51] = 2;
        exampleWorld[61][52] = 3;
        exampleWorld[62][50] = 1;
        exampleWorld[63][50] = 1;
        exampleWorld[64][50] = 1;
        exampleWorld[65][50] = 1;
        exampleWorld[66][50] = 1;
        exampleWorld[67][50] = 1;
        exampleWorld[51][40] = 3;
        exampleWorld[52][40] = 2;
        exampleWorld[53][40] = 1;
        exampleWorld[54][40] = 3;
        exampleWorld[55][40] = 2;
        exampleWorld[56][40] = 1;
        exampleWorld[57][40] = 1;
        exampleWorld[58][39] = 1;
        exampleWorld[58][42] = 3;
        exampleWorld[58][43] = 1;
        exampleWorld[59][39] = 1;
        exampleWorld[59][41] = 2;
        exampleWorld[59][43] = 2;
        exampleWorld[60][40] = 1;
        exampleWorld[60][41] = 2;
        exampleWorld[60][42] = 3;
        exampleWorld[60][43] = 1;
        exampleWorld[61][41] = 2;
        exampleWorld[61][42] = 3;
        exampleWorld[62][40] = 1;
        exampleWorld[63][40] = 1;
        exampleWorld[64][40] = 1;
        exampleWorld[65][40] = 1;
        exampleWorld[66][40] = 1;
        exampleWorld[67][40] = 1;
        wwMaker.GetComponent<wwMakerScript>().world = exampleWorld;
        runWw();
    }

    public void runWWExample3 ()
    {
        wwMaker.GetComponent<wwMakerScript>().len = 100;
        int[][] exampleWorld = new int[100][];
        for (int i = 0; i < 100; i++) exampleWorld[i] = new int[100];
        exampleWorld[50][50] = 2;
        exampleWorld[50][54] = 2;
        exampleWorld[51][49] = 1;
        exampleWorld[51][51] = 3;
        exampleWorld[51][53] = 1;
        exampleWorld[51][55] = 3;
        exampleWorld[52][49] = 1;
        exampleWorld[52][51] = 1;
        exampleWorld[52][53] = 1;
        exampleWorld[52][55] = 1;
        exampleWorld[53][49] = 1;
        exampleWorld[53][51] = 1;
        exampleWorld[53][53] = 1;
        exampleWorld[53][55] = 1;
        exampleWorld[54][49] = 1;
        exampleWorld[54][51] = 1;
        exampleWorld[54][53] = 1;
        exampleWorld[54][55] = 1;
        exampleWorld[55][50] = 1;
        exampleWorld[55][54] = 1;
        exampleWorld[56][50] = 1;
        exampleWorld[56][54] = 1;
        exampleWorld[58][50] = 1;
        exampleWorld[58][52] = 1;
        exampleWorld[58][54] = 1;
        exampleWorld[59][51] = 1;
        exampleWorld[59][52] = 1;
        exampleWorld[59][53] = 1;
        exampleWorld[60][52] = 1;
        exampleWorld[61][52] = 1;
        exampleWorld[62][52] = 1;
        exampleWorld[63][52] = 1;
        exampleWorld[50][60] = 2;
        exampleWorld[50][66] = 2;
        exampleWorld[51][59] = 1;
        exampleWorld[51][61] = 3;
        exampleWorld[51][65] = 1;
        exampleWorld[51][67] = 3;
        exampleWorld[52][59] = 1;
        exampleWorld[52][61] = 1;
        exampleWorld[52][65] = 1;
        exampleWorld[52][67] = 1;
        exampleWorld[53][59] = 1;
        exampleWorld[53][61] = 1;
        exampleWorld[53][65] = 1;
        exampleWorld[53][67] = 1;
        exampleWorld[54][59] = 1;
        exampleWorld[54][61] = 1;
        exampleWorld[54][65] = 1;
        exampleWorld[54][67] = 1;
        exampleWorld[55][60] = 1;
        exampleWorld[55][66] = 1;
        exampleWorld[57][60] = 1;
        exampleWorld[57][66] = 1;
        exampleWorld[58][60] = 1;
        exampleWorld[58][62] = 1;
        exampleWorld[58][63] = 1;
        exampleWorld[58][64] = 1;
        exampleWorld[58][66] = 1;
        exampleWorld[59][61] = 1;
        exampleWorld[59][62] = 1;
        exampleWorld[59][64] = 1;
        exampleWorld[59][65] = 1;
        exampleWorld[60][62] = 1;
        exampleWorld[60][63] = 1;
        exampleWorld[60][64] = 1;
        exampleWorld[61][62] = 1;
        exampleWorld[61][63] = 1;
        exampleWorld[61][64] = 1;
        exampleWorld[62][63] = 1;
        exampleWorld[63][63] = 1;
        exampleWorld[64][63] = 1;
        exampleWorld[65][63] = 1;
        wwMaker.GetComponent<wwMakerScript>().world = exampleWorld;
        runWw();
    }

    public void openWWManu ()
    {
        if (running.Equals("ww"))
        {
            wwMaker.GetComponent<wwMakerScript>().isRunning = false;
            wwMaker.SetActive(false);
            wwRUI.SetActive(false);
            wwMUi.SetActive(true);
        }
        else if (running.Equals("gol"))
        {
            golMaker.GetComponent<golMakerScript>().isRunning = false;
            golMaker.SetActive(false);
            golRUI.SetActive(false);
            wwMUi.SetActive(true);
        }
        else if (running.Equals("ll"))
        {
            llMaker.GetComponent<llMakerScript>().isRunning = false;
            llMaker.SetActive(false);
            golRUI.SetActive(false);
            wwMUi.SetActive(true);
        }
        else if (running.Equals("eca"))
        {
            ecaRUI.SetActive(false);
            ecaMUI.SetActive(true);
        }
        cam.transform.position = new Vector3 (cam.transform.position.x, cam.transform.position.y, 0);
    }

    public void closeWWManu ()
    {
        if (running.Equals("ww"))
        {
            wwMaker.SetActive(true);
            wwRUI.SetActive(true);
            wwMUi.SetActive(false);
        }
        else if (running.Equals("gol"))
        {
            golMaker.SetActive(true);
            golRUI.SetActive(true);
            wwMUi.SetActive(false);
        }
        else if (running.Equals("ll"))
        {
            llMaker.SetActive(true);
            golRUI.SetActive(true);
            wwMUi.SetActive(false);
        }
        else if (running.Equals("eca"))
        {
            ecaRUI.SetActive(true);
            ecaMUI.SetActive(false);
        }
        cam.transform.position = new Vector3 (cam.transform.position.x, cam.transform.position.y, -10);
    }

    public void closeText ()
    {
        foreach (GameObject text in textManager.GetComponent<textManagerScript>().texts)
        {
            text.SetActive(false);
        }
        textManager.GetComponent<textManagerScript>().nextButton.SetActive(false);
        textManager.GetComponent<textManagerScript>().lastButton.SetActive(false);
        textManager.SetActive(false);
        mainUI.SetActive(true);
    }

    public void openText0 ()
    {
        mainUI.SetActive(false);
        textManager.SetActive(true);
        textManager.GetComponent<textManagerScript>().scene = 0;
        textManager.GetComponent<textManagerScript>().currentTextIndex = 0;
        textManager.GetComponent<textManagerScript>().texts[0].SetActive(true);
        textManager.GetComponent<textManagerScript>().nextButton.SetActive(true);
    }

    public void openText1 ()
    {
        mainUI.SetActive(false);
        textManager.SetActive(true);
        textManager.GetComponent<textManagerScript>().scene = 2;
        textManager.GetComponent<textManagerScript>().currentTextIndex = textManager.GetComponent<textManagerScript>().lengths[0];
        textManager.GetComponent<textManagerScript>().texts[textManager.GetComponent<textManagerScript>().lengths[0]].SetActive(true);
        textManager.GetComponent<textManagerScript>().nextButton.SetActive(true);
    }

    public void openText2 ()
    {
        mainUI.SetActive(false);
        textManager.SetActive(true);
        textManager.GetComponent<textManagerScript>().scene = 4;
        textManager.GetComponent<textManagerScript>().currentTextIndex = textManager.GetComponent<textManagerScript>().lengths[2];
        textManager.GetComponent<textManagerScript>().texts[textManager.GetComponent<textManagerScript>().lengths[2]].SetActive(true);
        textManager.GetComponent<textManagerScript>().nextButton.SetActive(true);
    }

    public void openText3 ()
    {
        mainUI.SetActive(false);
        textManager.SetActive(true);
        textManager.GetComponent<textManagerScript>().scene = 6;
        textManager.GetComponent<textManagerScript>().currentTextIndex = textManager.GetComponent<textManagerScript>().lengths[4];
        textManager.GetComponent<textManagerScript>().texts[textManager.GetComponent<textManagerScript>().lengths[4]].SetActive(true);
        textManager.GetComponent<textManagerScript>().nextButton.SetActive(true);
    }

    public void openText4 ()
    {
        mainUI.SetActive(false);
        textManager.SetActive(true);
        textManager.GetComponent<textManagerScript>().scene = 8;
        textManager.GetComponent<textManagerScript>().currentTextIndex = textManager.GetComponent<textManagerScript>().lengths[6];
        textManager.GetComponent<textManagerScript>().texts[textManager.GetComponent<textManagerScript>().lengths[6]].SetActive(true);
        textManager.GetComponent<textManagerScript>().nextButton.SetActive(true);
    }

    public void reset ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
