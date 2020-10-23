using TMPro;
using UnityEngine;


public class BackgroundUI : MonoBehaviour
{
    #region Field

    public TMP_Text Time;
    public TMP_Text Rover;
    public TMP_Text Alloy;
    public TMP_Text Polymers;
    public TMP_Text Electronics;
    public TMP_Text Water;
    public TMP_Text Re;
    public TMP_Text Energy;
    public TMP_Text Chemicals;
    public TMP_Text Ore;
    public TMP_Text Food;
    public TMP_Text Raw;
    public TMP_Text Colonists;

    private GlobalDB _GlobalDB;

    #endregion


    #region UnityMethods

    private void Start()
    {
        _GlobalDB = GetComponentInParent<GlobalDB>();
        Draw();
    }

    #endregion


    #region Methods

    public void Draw()
    {
        //Debug.Log(_GlobalDB.Colonists.ToString());
        //Debug.Log(_GlobalDB.MasRes.Length.ToString());
        //Time.text = _GlobalDB.Time.ToString();
        Time.text           = _GlobalDB.MasRes[_GlobalDB.Time].ToString();
        Rover.text          = _GlobalDB.MasRes[_GlobalDB.Rover].ToString();
        Alloy.text          = _GlobalDB.MasRes[_GlobalDB.Alloy].ToString();
        Polymers.text       = _GlobalDB.MasRes[_GlobalDB.Polymers].ToString();
        Electronics.text    = _GlobalDB.MasRes[_GlobalDB.Electronics].ToString();
        Water.text          = _GlobalDB.MasRes[_GlobalDB.Water].ToString();
        Re.text             = _GlobalDB.MasRes[_GlobalDB.Re].ToString();
        Energy.text         = _GlobalDB.MasRes[_GlobalDB.Energy].ToString();
        Chemicals.text      = _GlobalDB.MasRes[_GlobalDB.Chemicals].ToString();
        Ore.text            = _GlobalDB.MasRes[_GlobalDB.Ore].ToString();
        Food.text           = _GlobalDB.MasRes[_GlobalDB.Food].ToString();
        Raw.text            = _GlobalDB.MasRes[_GlobalDB.Raw].ToString();
        Colonists.text      = _GlobalDB.MasRes[_GlobalDB.Colonists].ToString();
        //Debug.Log(Rover.text);



    }

    #endregion
}
