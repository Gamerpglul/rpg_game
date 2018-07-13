using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SaveEinstellungen : MonoBehaviour {

    private float musikLautstärke;
    private float soundLautstärke;

    public float MusikLautstärke
    {
        get
        {
            return musikLautstärke;
        }

        set
        {
            musikLautstärke = value;
        }
    }
    public float SoundLautstärke
    {
        get
        {
            return soundLautstärke;
        }

        set
        {
            soundLautstärke = value;
        }
    }


    void Start()
    {
        LoadFile();
    }


    public void SaveFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        Einstellungen data= new Einstellungen(musikLautstärke,soundLautstärke);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("SaveFile");
    }


    public void LoadFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            Debug.LogError("File not found");
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        Einstellungen data = (Einstellungen)bf.Deserialize(file);
        file.Close();

        MusikLautstärke = data.MusikLautstärke;
        SoundLautstärke = data.SoundLautstärke;
        Debug.Log("Laden der Einstelungen war erfolgreich");
    }
}
