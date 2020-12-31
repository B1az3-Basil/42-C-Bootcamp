using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class saveSystem
{
    public static  void saveInfo(scoreNumber score)
    {
        BinaryFormatter binary = new BinaryFormatter();
        string path = Application.persistentDataPath + "/mazeSave3.bblaze";

        FileStream stream = new FileStream(path, FileMode.Create);

        playersData playersData = new playersData(score);
        binary.Serialize(stream, playersData);
        stream.Close();
    }
    public static void saveSettings(buttons score)
    {
        BinaryFormatter binary = new BinaryFormatter();
        string path = Application.persistentDataPath + "/mazesettings.bblaze";

        FileStream stream = new FileStream(path, FileMode.Create);

       saveSettings playersData = new saveSettings(score);
        binary.Serialize(stream, playersData);
        stream.Close();
    }
    public static saveSettings loadSavedSettings()
    {
        string path = Application.persistentDataPath + "/mazesettings.bblaze";
        if (File.Exists(path))
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.Open);

            saveSettings Data = binary.Deserialize(file) as saveSettings;
            file.Close();
            return Data;
        }
        return null;
    }

    public static playersData loadSaved()
    {
        string path = Application.persistentDataPath + "/mazeSave3.bblaze";
        if (File.Exists(path))
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.Open);

            playersData Data = binary.Deserialize(file) as playersData;
            file.Close();
            return Data;
        }
        return null;
    }
}
