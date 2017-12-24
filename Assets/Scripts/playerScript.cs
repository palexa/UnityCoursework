using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;

public class playerScript : MonoBehaviour {
    public Camera CameraPlayer;
    public GameObject Player;
    public Texture2D imgCursor;
    public Text helpText;
    private bool statusHead = false;
    private bool freezePlayer;
    //Нужные мне углы поворота и всё такое
    Vector3 vec1 = new Vector3(0, 20, 0);
    Vector3 vec2 = new Vector3(0, 0, 17.1428571f);
    static int max=0;

    void GuiTextHelp()
    {
        Ray ray = CameraPlayer.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2) && (hit.collider.tag == "ActiveObject" || hit.collider.tag == "Pickupable"))
        {

            //string ObjectName = hit.collider.name;
            //helpText.text = hit.collider.name;


            if (hit.collider.name == "PIT")
            {
                helpText.text = "Нажмите \"E\", чтобы вкл./выкл. питание.";
            }
            if (hit.collider.name == "Switch single")
            {
                helpText.text = "Нажмите \"E\", чтобы вкл./выкл. свет.";
            }
            if (hit.collider.name == "Vkl_pitanie")
            {
                helpText.text = "Включить питание";
            }
            if (hit.collider.name == "Tumbler1")
            {
                helpText.text = "Врубить тумблер";
            }
            if (hit.collider.name == "Set'_tumbler")
            {
                helpText.text = "Врубить главный тумблер";
            }
            if (hit.collider.name == "ON")
            {
                helpText.text = "Включить питание.";
            }
            if (hit.collider.name == "OFF")
            {
                helpText.text = "Выключить питание.";
            }
            if (hit.collider.name == "Cylinder")
            {
                Rigidbody b = GameObject.Find("Cylinder").GetComponent<Rigidbody>();
                helpText.text = "Повернуть херь.";
                if (Input.GetMouseButtonDown(0))
                {
                    if (max != 8)
                    {
                        b.transform.Rotate(-vec1);
                        max++;
                        Izmer.Napryazhenie = max;
                        
                    }
                }
                if (Input.GetMouseButtonDown(1))
                {
                    if (max != 0)
                    {
                        b.transform.Rotate(vec1);
                        max--;
                        Izmer.Napryazhenie = max;
                    }
                }
            }
            if (hit.collider.name == "PointsOfControl")
            {
                Rigidbody b = GameObject.Find("PointsOfControl").GetComponent<Rigidbody>();
                helpText.text = "Повернуть счётчик точек контроля.";
                if (Input.GetMouseButtonDown(0))
                {
                    b.transform.Rotate(vec2);
                }
                if (Input.GetMouseButtonDown(1))
                {
                    b.transform.Rotate(-vec2);
                }
            }
            //if (hit.collider.tag == "Pickupable")
            //{
            //    helpText.text = "Нажмите и удерживайте левую клавишу мыши, чтобы перенести образец.";
            //}
            if (hit.collider.name == "Stand")
            {
                helpText.text = "Поставьте сюда образец для измерения коэффициента преломления.";
            }



        }
        else helpText.text = "";
    }
    // Use this for initialization
    void Start()
    {
        //Cursor.SetCursor(imgCursor, Vector2.zero, CursorMode.Auto);
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = true;
        CameraPlayer.enabled = true;
        //GameObject.Find("Spotlight").GetComponent<Light>().enabled = false;
        helpText.color = Color.white;

    }
    void FixedUpdate()
    {
        GuiTextHelp();
    }
}
