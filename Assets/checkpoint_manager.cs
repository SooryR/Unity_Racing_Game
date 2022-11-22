using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class checkpoint_manager : MonoBehaviour
{
    public int checkpoint_number;
    public Text Points;

    void Start()
    {
        checkpoint_number = 0;
    }

    public void hit_checkpoint()
    {
        checkpoint_number+=1;
        Points.text = checkpoint_number+"";
        Debug.Log(checkpoint_number);

    }

}
