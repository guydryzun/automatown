using UnityEngine;

public class titleGolScript : MonoBehaviour
{
    public int[][] world = null;
    public GameObject[][] block;
    public GameObject objectPool;
    public int len, len2;
    private float timer = 0f, speed = 1.0f;


    private void Start()
    {
        world = new int[len][];
        for (int i = 0; i < len; i++) world[i] = new int[len2];
        startingGrid();
        block = new GameObject[len][];
        for (int i = 0; i < len; i++) block[i] = new GameObject[len2];
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len2; j++)
            {
                Vector3 newT = new Vector3(transform.position.x + 0.15f * j, transform.position.y - 0.15f * i, transform.position.z);
                block[i][j] = objectPool.GetComponent<ObjectPool>().GetObject();
                block[i][j].transform.position = newT;
                block[i][j].transform.rotation = transform.rotation;
                block[i][j].SetActive(true);
                if (world[i][j] == 1) block[i][j].GetComponent<SpriteRenderer>().color = Color.black;
            }
        }
    }

    private void Update()
    {
        if (block[1][1] == null) return;
        timer += Time.deltaTime;
        if (timer >= speed)
        {
            world = nextGen(world);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (world[i][j] == 1) block[i][j].GetComponent<SpriteRenderer>().color = Color.black;
                    else block[i][j].GetComponent<SpriteRenderer>().color = Color.white;
                }
            }
            timer = 0f;
        }
    }

    private int[][] nextGen(int[][] arr)
    {
        int[][] newGen = new int[arr.Length][];
        for (int i = 0; i < arr.Length; i++) newGen[i] = new int[arr[i].Length];
        for (int i = 1; i < arr.Length - 1; i++)
        {
            for (int j = 1; j < arr[i].Length - 1; j++)
            {
                int sum = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1] + arr[i][j - 1] + arr[i][j + 1] + arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                if (sum == 3) newGen[i][j] = 1;
                else if (sum == 2) newGen[i][j] = arr[i][j];
                else newGen[i][j] = 0;
            }
        }
        return newGen;
    }

    private void startingGrid()
    {
        world[15][19] = 1;
        world[15][20] = 1;
        world[16][19] = 1;
        world[16][20] = 1;
        world[17][19] = 1;
        world[17][20] = 1;
        world[18][18] = 1;
        world[18][20] = 1;
        world[19][18] = 1;
        world[19][20] = 1;
        world[19][21] = 1;
        world[20][18] = 1;
        world[20][21] = 1;
        world[21][17] = 1;
        world[21][18] = 1;
        world[21][19] = 1;
        world[21][20] = 1;
        world[21][21] = 1;
        world[22][17] = 1;
        world[22][21] = 1;
        world[22][22] = 1;
        world[23][17] = 1;
        world[23][22] = 1;
        //
        world[14][29] = 1;
        world[15][25] = 1;
        world[15][29] = 1;
        world[16][25] = 1;
        world[16][29] = 1;
        world[17][25] = 1;
        world[17][29] = 1;
        world[18][25] = 1;
        world[18][29] = 1;
        world[18][30] = 1;
        world[19][25] = 1;
        world[19][30] = 1;
        world[20][25] = 1;
        world[20][30] = 1;
        world[21][25] = 1;
        world[21][26] = 1;
        world[21][29] = 1;
        world[21][30] = 1;
        world[22][26] = 1;
        world[22][27] = 1;
        world[22][28] = 1;
        world[22][29] = 1;
        //
        world[14][33] = 1;
        world[14][34] = 1;
        world[14][35] = 1;
        world[14][36] = 1;
        world[14][37] = 1;
        world[14][38] = 1;
        world[15][35] = 1;
        world[16][35] = 1;
        world[17][35] = 1;
        world[18][35] = 1;
        world[19][35] = 1;
        world[20][36] = 1;
        world[21][36] = 1;
        world[22][36] = 1;
        world[23][36] = 1;
        //
        world[14][43] = 1;
        world[14][44] = 1;
        world[14][45] = 1;
        world[15][42] = 1;
        world[15][45] = 1;
        world[16][41] = 1;
        world[16][42] = 1;
        world[16][45] = 1;
        world[17][41] = 1;
        world[17][45] = 1;
        world[17][46] = 1;
        world[18][40] = 1;
        world[18][41] = 1;
        world[18][46] = 1;
        world[19][40] = 1;
        world[19][46] = 1;
        world[20][40] = 1;
        world[20][41] = 1;
        world[20][45] = 1;
        world[20][46] = 1;
        world[21][41] = 1;
        world[21][45] = 1;
        world[22][41] = 1;
        world[22][43] = 1;
        world[22][44] = 1;
        world[23][42] = 1;
        world[23][43] = 1;
        //
        world[13][49] = 1;
        world[13][50] = 1;
        world[13][56] = 1;
        world[14][49] = 1;
        world[14][50] = 1;
        world[14][51] = 1;
        world[14][54] = 1;
        world[14][55] = 1;
        world[14][56] = 1;
        world[15][49] = 1;
        world[15][51] = 1;
        world[15][52] = 1;
        world[15][53] = 1;
        world[15][54] = 1;
        world[15][56] = 1;
        world[16][49] = 1;
        world[16][52] = 1;
        world[16][53] = 1;
        world[16][56] = 1;
        world[17][49] = 1;
        world[17][56] = 1;
        world[18][49] = 1;
        world[18][56] = 1;
        world[19][49] = 1;
        world[19][56] = 1;
        world[20][49] = 1;
        world[20][56] = 1;
        world[21][49] = 1;
        world[21][56] = 1;
        world[22][49] = 1;
        world[22][56] = 1;
        world[23][49] = 1;
        world[23][56] = 1;
        world[24][49] = 1;
        world[24][56] = 1;
        //
        world[15][61] = 1;
        world[15][62] = 1;
        world[16][61] = 1;
        world[16][62] = 1;
        world[17][60] = 1;
        world[17][62] = 1;
        world[18][60] = 1;
        world[18][62] = 1;
        world[19][59] = 1;
        world[19][60] = 1;
        world[19][62] = 1;
        world[20][59] = 1;
        world[20][63] = 1;
        world[21][59] = 1;
        world[21][63] = 1;
        world[22][58] = 1;
        world[22][59] = 1;
        world[22][60] = 1;
        world[22][61] = 1;
        world[22][62] = 1;
        world[22][63] = 1;
        world[22][64] = 1;
        world[23][58] = 1;
        world[23][64] = 1;
        world[24][58] = 1;
        world[24][64] = 1;
        //
        world[13][65] = 1;
        world[13][66] = 1;
        world[13][67] = 1;
        world[13][68] = 1;
        world[14][68] = 1;
        world[14][69] = 1;
        world[14][70] = 1;
        world[14][71] = 1;
        world[15][68] = 1;
        world[16][68] = 1;
        world[17][68] = 1;
        world[18][68] = 1;
        world[19][68] = 1;
        world[20][68] = 1;
        world[21][68] = 1;
        world[22][68] = 1;
        world[23][68] = 1;
        world[24][68] = 1;
        //
        world[15][76] = 1;
        world[15][77] = 1;
        world[15][78] = 1;
        world[16][75] = 1;
        world[16][76] = 1;
        world[16][79] = 1;
        world[16][80] = 1;
        world[17][75] = 1;
        world[17][80] = 1;
        world[18][74] = 1;
        world[18][80] = 1;
        world[19][74] = 1;
        world[19][79] = 1;
        world[19][80] = 1;
        world[20][74] = 1;
        world[20][79] = 1;
        world[21][74] = 1;
        world[21][75] = 1;
        world[21][79] = 1;
        world[22][75] = 1;
        world[22][78] = 1;
        world[22][79] = 1;
        world[23][75] = 1;
        world[23][76] = 1;
        world[23][78] = 1;
        world[24][76] = 1;
        world[24][77] = 1;
        //
        world[13][93] = 1;
        world[14][83] = 1;
        world[14][93] = 1;
        world[15][83] = 1;
        world[15][84] = 1;
        world[15][92] = 1;
        world[15][93] = 1;
        world[16][84] = 1;
        world[16][85] = 1;
        world[16][92] = 1;
        world[17][85] = 1;
        world[17][88] = 1;
        world[17][89] = 1;
        world[17][92] = 1;
        world[18][85] = 1;
        world[18][88] = 1;
        world[18][89] = 1;
        world[18][91] = 1;
        world[19][85] = 1;
        world[19][87] = 1;
        world[19][88] = 1;
        world[19][89] = 1;
        world[19][91] = 1;
        world[20][85] = 1;
        world[20][86] = 1;
        world[20][87] = 1;
        world[20][89] = 1;
        world[20][91] = 1;
        world[21][86] = 1;
        world[21][87] = 1;
        world[21][90] = 1;
        world[21][91] = 1;
        world[22][86] = 1;
        world[22][87] = 1;
        world[22][90] = 1;
        world[22][91] = 1;
        world[23][87] = 1;
        //
        world[12][97] = 1;
        world[13][97] = 1;
        world[14][97] = 1;
        world[15][97] = 1;
        world[15][100] = 1;
        world[15][101] = 1;
        world[15][102] = 1;
        world[16][97] = 1;
        world[16][99] = 1;
        world[16][102] = 1;
        world[16][103] = 1;
        world[17][97] = 1;
        world[17][98] = 1;
        world[17][99] = 1;
        world[17][103] = 1;
        world[18][97] = 1;
        world[18][98] = 1;
        world[18][103] = 1;
        world[18][104] = 1;
        world[19][98] = 1;
        world[19][104] = 1;
        world[20][98] = 1;
        world[20][104] = 1;
        world[21][98] = 1;
        world[21][104] = 1;
        world[22][98] = 1;
    }
}
