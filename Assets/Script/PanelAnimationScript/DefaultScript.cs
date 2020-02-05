using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultScript : MonoBehaviour
{
    [SerializeField] private Material LibraryMaterial;
    [SerializeField] private Material FEMaterial;
    [SerializeField] private Material SEMaterial;
    [SerializeField] private Material TEMaterial;
    [SerializeField] private Material SSMaterial;
    [SerializeField] private Material MainMaterial;
    [SerializeField] private Material InternationalMaterial;
    [SerializeField] private Material InmunMaterial;
    [SerializeField] private Material SabumMaterial;
    [SerializeField] private Material SanggyungMaterial;
    [SerializeField] private Material DentistMaterial;
    [SerializeField] private Material WestMaterial;
    [SerializeField] private Material ICTMaterial;
    [SerializeField] private Material MusicMaterial;
    [SerializeField] private Material NewMuseumMaterial;
    [SerializeField] private Material PlaygroundMaterial;
    [SerializeField] private Material HyedangMaterial;
    [SerializeField] private Material ArtistMaterial;
    [SerializeField] private Material GraduateMaterial;
    [SerializeField] private Material SukJuSunMaterial;
    [SerializeField] private Material LabMaterial;
    [SerializeField] private Material YunminMaterial;
    [SerializeField] private Material ParkingMaterial;
    [SerializeField] private Material GymMaterial;
    [SerializeField] private Material ROTCMaterial;
    public Button mybutton;
    void Start()
    {
        mybutton.onClick.AddListener(OnClickDefaultMaterial);
    }

    public void OnClickDefaultMaterial()
    {
        LibraryHighLight.libraryobject.material = LibraryMaterial;
        FEHighLight.FEobject.material = FEMaterial;
        SEHighLight.SEobject.material = SEMaterial;
        TEHighLight.TEobject.material = TEMaterial;
        SSHighLight.SSobject.material = SSMaterial;
        MainHighLight.Mainobject.material = MainMaterial;
        InternationalHighLight.Interobject.material = InternationalMaterial;
        InmunHighLight.inmunobject.material = InmunMaterial;
        SabumHighLight.Sabumobject.material = SabumMaterial;
        SanggyungHighLight.Sanggyungobject.material = SanggyungMaterial;
        DentistHighLight.Dentistobject.material = DentistMaterial;
        WestHighLight.Westobject.material = WestMaterial;
        ICTHighLight.ICTobject.material = ICTMaterial;
        MusicHighLight.Musicobject.material = MusicMaterial;
        NewMuseumHighLight.NewMuseumojbect.material = NewMuseumMaterial;
        PlaygroundHighLight.Playgroundobject.material = PlaygroundMaterial;
        HyedangHighLight.Hyedangojbect.material = HyedangMaterial;
        ArtistHighLight.Artistobject.material = ArtistMaterial;
        GraduateHighLight.Graduateobject.material = GraduateMaterial;
        SukJuSunHIghLight.Sukobject.material = SukJuSunMaterial;
        LabHighLight.Labobject.material = LabMaterial;
        YunminHighLight.Yunminobject.material = YunminMaterial;
        ParkingHighLight.Parkingobject.material = ParkingMaterial;
        GymHighLight.Gymobject.material = GymMaterial;
        ROTCHighLight.ROTCobject.material = ROTCMaterial;

    }
}
