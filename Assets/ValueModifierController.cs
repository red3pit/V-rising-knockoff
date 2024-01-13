using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueModifierController : MonoBehaviour
{
    public ValueContainer valueContainer;
    public string sceneName;

    private void Awake()
    {
        valueContainer.ResetValue(100);
        OpenUIScene();
    }
    private void OnTriggerEnter(Collider other)
    {
        ValueModifier valueModifier = other.GetComponent<ValueModifier>();

        if (valueModifier != null)
        {
            valueModifier.ModifyValue();
            Debug.Log("Value modified!");
        }
    }

    private void OpenUIScene()
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
    }
}
