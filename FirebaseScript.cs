using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;

public class Water
{
    public string _waterType;
    public int _inAmount;

    public Water(string waterType, int inAmount)
    {
        this._waterType = waterType;
        this._inAmount = inAmount;
    }
}

public class FirebaseScript : MonoBehaviour
{
    private string DBurl = "#####";

    private DatabaseReference dbRef;
    
    void Start()
    {
        FirebaseApp.DefaultInstance.Options.DatabaseUrl = new Uri(DBurl);
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;

        WriteDB();
        ReadDB();
    }

    void WriteDB()
    {
        Water item = new Water("Coke", 300);
        string json = JsonUtility.ToJson(item);
        dbRef.Child("users").SetRawJsonValueAsync(json);
    }

    void ReadDB()
    {
        dbRef.GetValueAsync().ContinueWith(task =>
        {
            if (task.IsCompleted)
            {
                DataSnapshot snap = task.Result;

                foreach (var item in snap.Children)
                {
                    IDictionary wt = (IDictionary)item.Value;
                    Debug.Log(wt["_waterType"]);
                }
            }
        });
    }
}
