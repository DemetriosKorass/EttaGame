using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    // Prefabs
    [SerializeField]
    private GameObject HorLine;
    [SerializeField]
    private GameObject VertLine;
    [SerializeField]
    private GameObject CardPref;
    private List<GameObject> grid_lines = new List<GameObject>();

    private Vector3 start_pos_hor = new Vector3(0f, 0f, -9.5f);
    private Vector3 start_pos_vert = new Vector3(-9.5f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        // Create grid
        float step = 19f / 70f;

        for (int i = 0; i <70; i++)
        {
            grid_lines.Add(Instantiate(HorLine, new Vector3(start_pos_hor[0], start_pos_hor[1], start_pos_hor[2] + step * i), Quaternion.Euler(0,90,0)));
            grid_lines.Add(Instantiate(VertLine, new Vector3(start_pos_vert[0] + step*i, start_pos_vert[1], start_pos_vert[2]), Quaternion.identity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
