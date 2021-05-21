using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carRespawn : MonoBehaviour
{
    public Transform Car;
    private Vector3 m_start_pos;
    private Quaternion m_start_quat;
    public int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_start_pos = Car.position;
        m_start_quat = Car.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _pos = Car.position;
        Quaternion _quat = Car.rotation;
        

        if(_pos[1] <= 10)
        {
            transform.position = m_start_pos;
            transform.rotation = m_start_quat;
        }

        if (_quat[2]%360 > 85 || _quat[2]%360 < -85)
        {
            timer += 1;
            if (timer > 1000)
            {
                timer = 0;
                transform.position = m_start_pos;
                transform.rotation = m_start_quat;
            }
        }
        else
        {
            timer = 0;
        }
    }
}
