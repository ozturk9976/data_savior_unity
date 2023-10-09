using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class class1
{
    public float class1_float;
    public Quaternion class1_quaternion;
    public Vector2 class1_vector2;
}


[System.Serializable]

public class class2
{
    public string class2_string;
    public int class2_int;
    public Vector3 class2_vector3;
}



public class SaveDataTest : MonoBehaviour
{
    public class1 cls1;
    public class2 cls2;


    public void SaveData()
    {
        DataSavior.SaveData<class1>(cls1, "Class1");
        DataSavior.SaveData<class2>(cls2, "Class2");
    }

    public void LoadData()
    {
        //DataSavior.LoadData("Class1");
    }
}
