using UnityEngine;
using UnityEngine.UI;

public class VendingMachineController : MonoBehaviour
{
    public Button insertButton;
    public Button cancelButton;
    public Button orderButton;
    public Button maintenanceButton;

    private void Start()
    {
        // Exemplo de como ligar os botões a funções
        insertButton.onClick.AddListener(OnInsertClicked);
        cancelButton.onClick.AddListener(OnCancelClicked);
        orderButton.onClick.AddListener(OnOrderClicked);
        maintenanceButton.onClick.AddListener(OnMaintenanceClicked);
    }

    private void OnInsertClicked()
    {
        Debug.Log("Inserir moeda clicado");
        // Aqui será a lógica para inserir moeda
    }

    private void OnCancelClicked()
    {
        Debug.Log("Cancelar clicado");
        // Lógica para cancelar compra
    }

    private void OnOrderClicked()
    {
        Debug.Log("Comprar clicado");
        // Lógica para comprar refrigerante
    }

    private void OnMaintenanceClicked()
    {
        Debug.Log("Manutenção clicado");
        // Lógica para entrar no modo manutenção
    }
}

