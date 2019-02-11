using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabscript : MonoBehaviour
{
    public GameObject box;
    private GameObject _gameobject;
    private List<GameObject> _golist;
    private Color[] _myarray;

    public float numofGO = 9;
    public float length = 1f;
    // Start is called before the first frame update
    void Start()
    {
        _myarray = new Color[3];
        _golist = new List<GameObject>();
        _myarray[0]=(Color.blue);
        _myarray[1]=(Color.red);
        _myarray[2]=(Color.magenta);


        for (int i = 0; i < numofGO; i++)
        {
            float angle = i * Mathf.PI * (2 / numofGO);
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0.1f, Mathf.Sin(angle)) * length;
            _gameobject = Instantiate<GameObject>(box, pos, Quaternion.identity);
            _gameobject.GetComponent<Renderer>().material.color = _myarray[i%3];
            _golist.Add(_gameobject);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
