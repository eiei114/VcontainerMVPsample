using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField]private Button _button;
    [SerializeField]private Text _text;
    
    public UnityEvent ButtonClick => _button.onClick;
    public string Text { set=> _text.text = value;}
}
