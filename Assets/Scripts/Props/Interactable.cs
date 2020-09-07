using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] private GameObject inputPrompt = null;

    [SerializeField] private bool canInteract;

    public void ShowInputPrompt()
    {
        if (!canInteract) return;
        inputPrompt.SetActive(true);
    }

    public void HideInputPrompt()
    {
        inputPrompt.SetActive(false);
    }

    public void SetInteractable(bool interactable)
    {
        canInteract = interactable;
    }

    public void ApproachPlayer()
    {
        ShowInputPrompt();
    }

    public void RetreatPlayer()
    {
        HideInputPrompt();
    }

    public abstract void Interact();
}
