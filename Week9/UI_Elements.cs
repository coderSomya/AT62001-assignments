using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class UI_Elements : MonoBehaviour
{
    public Button backButton;
    public Slider rotateY;
    public Slider rotateX;
    public Slider rotateZ;
    public Slider scaleX;
    public Slider scaleY;
    public Slider scaleZ;

    public Button realign;
    public Button rescale;
    public TextMeshProUGUI debugText;

    bool rescaled  = false;
    bool realigned = false;

    int count;
    
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        backButton.onClick.AddListener(backButtonClick);
        realign.onClick.AddListener(realignclick);
        rescale.onClick.AddListener(rescaleclick);
    }

    void backButtonClick()
    {
        Debug.Log("clicked");
        count++;
        debugText.text = count.ToString();
        SceneManager.LoadScene("MenuScreen");
    }
    
    void realignclick()
    {
        Debug.Log("realigning");
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        Debug.Log(transform.rotation);
        realigned = !realigned;
    }

    void rescaleclick()
    {
        Debug.Log("rescaling");
        transform.localScale = new Vector3(1f, 1f, 1f);
        Debug.Log(transform.localScale);

        rescaled = !rescaled;
    }

    // Update is called once per frame
    void Update()
    {
        float scaleFactorx= Mathf.Lerp(1f,4f,scaleX.value);
        float scaleFactory = Mathf.Lerp(1f,4f,scaleY.value);
        float scaleFactorz= Mathf.Lerp(1f,4f,scaleZ.value);


        if (!realigned)
        {

            transform.rotation = Quaternion.Euler(rotateX.value, rotateY.value, rotateZ.value);
        }

        if(!rescaled)
        {
            transform.localScale = new Vector3(scaleFactorx, scaleFactory, scaleFactorz);
        }

        
    }
}
