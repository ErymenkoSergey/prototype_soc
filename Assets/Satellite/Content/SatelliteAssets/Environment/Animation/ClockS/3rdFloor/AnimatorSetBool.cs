using UnityEngine;

public sealed class AnimatorSetBool : MonoBehaviour
{
    [SerializeField] private Animator _clockSpace;
    [SerializeField] private string _boolParName;
    [SerializeField] private bool _isEnableStatus;

    public void SetStatusAnim() => _clockSpace.SetBool(_boolParName, _isEnableStatus);
}
