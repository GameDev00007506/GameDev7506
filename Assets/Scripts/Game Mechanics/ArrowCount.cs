using UnityEngine;
using UnityEngine.UI;

public class ArrowCount : MonoBehaviour
{
    [SerializeField] private Text _arrowCountText;
    private int _arrowCount = 20;

    private void Start()
    {
        ShowText();
    }

    private void ShowText()
    {
        _arrowCountText.text = $"X : {_arrowCount}";
    }

    public void ArrowDecrease(int decreaseNumber)
    {
        if (_arrowCount > 0)
        {
            _arrowCount -= decreaseNumber;
            ShowText();
        }
        
    }
}
