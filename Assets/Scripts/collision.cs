using UnityEngine;
using TMPro;


public class Item_collect : MonoBehaviour
{
    private TMP_Text col_keys;
    private TMP_Text mission_text;
    private TMP_Text final_time;
    private TMP_Text _time;
    private int keys = 0;
    private GameObject ui;
    private GameObject go;
    private Material material;


    private void Start()
    {
        mission_text = GameObject.Find("Mission_Text").GetComponent<TMP_Text>();
        final_time = GameObject.Find("time").GetComponent<TMP_Text>();
        _time = GameObject.Find("Timer").GetComponent<TMP_Text>();
        ui = GameObject.Find("UI");
        go = GameObject.Find("Game_Over");
        go.SetActive(false);
        ui.SetActive(true);

    }
    private void OnCollisionEnter(Collision collision)
    {
        string _tag = collision.gameObject.tag;
        switch(_tag)
        {
            case "Key":
                material = collision.gameObject.GetComponent<Renderer>().material;
                collision.gameObject.tag = "Untagged";
                material.color = Color.red;
                keys++;
            break;
            case "Finish":
                go.SetActive(true);
                ui.SetActive(false);
                Destroy(GameObject.Find("Player"));
                final_time.text = _time.text;
            break;
        }
    }
    private void Update()
    {
        if (keys < 7)
        {
            mission_text.text = "Знайдіть всі ключі. "+ keys.ToString()+"/7";
        }
        else if(keys == 7)
        {
            mission_text.text = "Знайдіть вихід";
            Destroy(GameObject.Find("door"));
        }
        else
        {
            mission_text.text = "Помилка";
        }
    }

}
