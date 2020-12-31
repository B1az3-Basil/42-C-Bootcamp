using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class fade_in : MonoBehaviour
{
    public Image img;
    public AnimationCurve curve;

    private void Start()
    {
        StartCoroutine(fade_in_());
    }

    public void fade_to(string scene)
    {
        StartCoroutine(fade_out_(scene));
    }

    IEnumerator fade_in_()
    {
        float t = 1f;
        float a;

        while (t > 0f)
        {
            t -= Time.deltaTime;
            a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }
    }

    IEnumerator fade_out_(string scene)
    {
        float t = 0f;
        float a;

        while (t < 1f)
        {
            t += Time.deltaTime;
            a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }
        SceneManager.LoadScene(scene);

    }
}
