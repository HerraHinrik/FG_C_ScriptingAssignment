using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
   [SerializeField] private Image progressBar;
   [SerializeField] private Button button;
   [SerializeField] private TextMeshProUGUI charaterName;

   private void Start()
   {
      button.onClick.AddListener(OnbuttonPressed);
   }

   public void OnbuttonPressed()
   {
      float randomValue = Random.Range(0f, 1f);
      progressBar.fillAmount = randomValue;
   }
      
}
