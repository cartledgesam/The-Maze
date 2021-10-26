using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Movement : MonoBehaviour
{

    public float speed;

    private float amountToMove;
    SerialPort sp = new SerialPort("COM3", 9600);
    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        amountToMove = speed * Time.deltaTime;
        if (sp.IsOpen)
        {
            try
            {
                MoveObject(sp.ReadByte());
                print(sp.ReadByte());
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }

    void MoveObject(int Direction)
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.left * amountToMove, Space.World);
        }
        if (Direction == 2)
        {
            transform.Translate(Vector3.left * amountToMove, Space.World);
        }
    }
}
