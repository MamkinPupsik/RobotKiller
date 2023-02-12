using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    [SerializeField] private Slider _sliderStamina;
    [SerializeField] private Text _currentStaminaText;

    [Space(10)]
    [SerializeField] public float _currentStamina;
    [SerializeField] private float _maxStamina;
    [SerializeField] private float _minStamina;
    [SerializeField] private bool _tiredChecked;

    private void Start()
    {
        _sliderStamina.maxValue = _maxStamina;
        _sliderStamina.minValue = _minStamina;

        _currentStamina = _maxStamina;
    }

    private void Update()
    {
        _sliderStamina.value = _currentStamina;
        _currentStaminaText.GetComponent<Text>().text = string.Format("{0:0}%", _currentStamina);

        StaminaChecked();
        StaminaKeys();
    }

    //Проверка выводимой стамины
    private void StaminaChecked()
    {
        Player player = GameObject.Find("Player").GetComponent<Player>();
        if (_currentStamina <= _minStamina)
        {
            _currentStamina = _minStamina;
                player.Tired = true;
        }
        if (_currentStamina >= 10)
        {
            player.Tired = false;
        }
            
        if (_currentStamina >= _maxStamina)
        {
            _currentStamina = _maxStamina;
        }
            
    }

    //Востановление и сжигание стамины
    private void StaminaKeys()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _currentStamina -= Time.deltaTime * 2f;
            }
        }
        else
            _currentStamina += Time.deltaTime * 1f;
    }
}
