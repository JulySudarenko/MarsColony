using UnityEngine;


public class Turn : MonoBehaviour
{
    #region Field

    [SerializeField] private ResourcesCalculation _resouces;
    [SerializeField] private BuildingsCalculation _buildings;
    [SerializeField] private BackgroundUI _background;

    #endregion


    #region UnityMethods

    private void Start()
    {
        _resouces.GetComponent<ResourcesCalculation>();
        _buildings.GetComponent<BuildingsCalculation>();
        _background.GetComponent<BackgroundUI>();
    }
    #endregion


    #region Methods

    public void NextTurn()
    {
        _resouces.Calculate();
        //_buildings.Calculate();
        _background.Draw();
    }

    #endregion
}
