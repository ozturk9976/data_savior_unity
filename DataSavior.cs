using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class DataSavior : MonoBehaviour
{
    private static readonly string keyWord = "321451";
    public static void SaveData<T>(T mySaveObj, string save_Key)
    {
        var saveData = JsonUtility.ToJson(mySaveObj);
        string data = Encrypt(saveData);
        PlayerPrefs.SetString(save_Key, data);
    }
    /*
        public static string LoadData<T>(T myLoadObj, string myLoadObj_Key)
        {
            var prefsData = PlayerPrefs.GetString(myLoadObj_Key);
            // var loadData = JsonUtility.FromJson<myLoadObj>(prefsData);
            var refinedData = Encrypt(loadData);
            //Debug.Log(refinedData.ToString());
            return refinedData;
        }
    */
    public static bool DeleteData(string myDeleteObj_Key)
    {
        PlayerPrefs.DeleteKey(myDeleteObj_Key);
        return true;
    }

    private static string Encrypt(string data)
    {
        string result = "";

        for (int i = 0; i < data.Length; i++)
        {
            result += (char)(data[i] ^ keyWord[i % keyWord.Length]);
        }

        return result;
    }
}
