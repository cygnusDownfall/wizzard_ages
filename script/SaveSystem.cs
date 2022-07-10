using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.IO;


public static class SaveSystem 
{

    public static void save(DataSaving data,int keysave)
    {
        BinaryFormatter filesave = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data" + keysave + ".caigidoratgivanayno";
        FileStream stream = new FileStream(path, FileMode.Create);

        filesave.Serialize(stream, data);
        stream.Close();
    }
    public static DataSaving load(int key)
    {
        string path = Application.persistentDataPath + "/data"+key+".caigidoratgivanayno";
        if (File.Exists(path))
        {

            BinaryFormatter filesave = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            return filesave.Deserialize(stream) as DataSaving;
        }
        else
        {
            Debug.LogWarning(@"lam j co file nay  !!!!!!!");
            return null;
        }
        
    }
}
