using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CylinderPivotScript1 : MonoBehaviour
{
    public Animator transitionAnim;
    string newLevelString;

    private float speed = 1.5f;

    int level;


    public float Speed { get => speed; set => speed = value; }
    [HideInInspector] public float angleCylinder;

    // Start is called before the first frame update
    void Start()
    {
        level = LevelStaticDataScript.level;

    }

    // Update is called once per frame
    void Update()
    {
        bool left = GameObject.Find("ArrowLeft").GetComponent<ArrowLeftScript>().ArrowLeftPressed;
        bool right = GameObject.Find("ArrowRight").GetComponent<ArrowRightScript>().ArrowRightPressed;

        if (left == true)
        {
            transform.Translate(Speed * Time.deltaTime * -1, 0, 0, relativeTo: Space.World);
        }
        else if (right == true)
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0, relativeTo: Space.World);
        }
    }

    public void CylinderNewAngle(float angle)
    {
        angleCylinder = angle;
        transform.eulerAngles = new Vector3(0, 0, angle - 90f);
    }

    public void SuccessTarget()
    {
        LevelStaticDataScript.UpdateLevel();
        Invoke("UpdateLevelTransition", 2);
    }

    public void UpdateLevelTransition()
    {
        GameObject.Find("Panel").GetComponent<PanelScript>().MovePanelIn();
        StartCoroutine(NextLevel());

    }

    IEnumerator NextLevel()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.3f);
        if (level < 20)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}
