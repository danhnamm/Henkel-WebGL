using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
//using UnityEngine.UIElements;

public class Language : MonoBehaviour
{
    public VideoPlayer videoPlayer;
  
    public GameObject xinchao;
    public GameObject welcome;

    public SpriteRenderer KinhMoi;
    public Sprite KinhMoien,kinhmoivi;


    public SpriteRenderer Hoinghi;
    public Sprite hoignhiEn,hoinghivi;


    public SpriteRenderer Layer17;
    public Sprite timeEN,timevi;


    public SpriteRenderer denvoi;
    public Sprite denvoiEN,denvoivi;


    public SpriteRenderer VinhHalong;
    public Sprite VinhhalongEn,vinhhalongvi;


    public SpriteRenderer Welcome;
    public Sprite welcomeen,welcomevi;


    public SpriteRenderer yentu;
    public Sprite yentuen,yentuvi;


    public SpriteRenderer golf;
    public Sprite golfen,golfvi;


    public SpriteRenderer gala;
    public Sprite galaen,galavi;

    public SpriteRenderer camon;
    public Sprite camonen,camonvi;

    public SpriteRenderer text1;
    public Sprite text1en,text1vi;

    public SpriteRenderer text2;
    public Sprite text2en,text2vi;

    public SpriteRenderer text3;
    public Sprite text3en,text3vi;

    [SerializeField]
    public Button button;
    public Sprite enButton,viButton;

    public Button button2;
    public Sprite enButton2,viButton2;

    public Button button3;
    public Sprite enButton3,viButton3;

    public Button button4;
    public Sprite enButton4,viButton4;

    public Button button5;
    public Sprite enButton5,viButton5;

    public Button replayy;
    public Sprite replayen,replayVi;
    public void changeToEn()
    {
        KinhMoi.sprite = KinhMoien;
        Hoinghi.sprite = hoignhiEn;
        Layer17.sprite = timeEN;
        denvoi.sprite = denvoiEN;
        VinhHalong.sprite = VinhhalongEn;
        Welcome.sprite = welcomeen;
        yentu.sprite = yentuen;
        golf.sprite = golfen;
        gala.sprite = galaen;

        camon.sprite = camonen;

        text1.sprite = text1en;
        text2.sprite = text2en;
        text3.sprite = text3en;



        button.image.sprite = enButton;
        button2.image.sprite = enButton2;
        button3.image.sprite = enButton3;
        button4.image.sprite = enButton4;
        button5.image.sprite = enButton5;
        replayy.image.sprite = replayen;

    }
    public void changeToVi()
    {
        KinhMoi.sprite = kinhmoivi;
        Hoinghi.sprite = hoinghivi;
        Layer17.sprite = timevi;
        denvoi.sprite = denvoivi;
        VinhHalong.sprite = vinhhalongvi;
        Welcome.sprite = welcomevi;
        yentu.sprite = yentuvi;
        golf.sprite = golfvi;
        gala.sprite = galavi;

        camon.sprite = camonvi;

        text1.sprite = text1vi;
        text2.sprite = text2vi;
        text3.sprite = text3vi;



        button.image.sprite = viButton;
        button2.image.sprite = viButton2;
        button3.image.sprite = viButton3;
        button4.image.sprite = viButton4;
        button5.image.sprite = viButton5;
        replayy.image.sprite = replayVi;

    }

    public void tiengViet()
    {
        xinchao.SetActive(true);
        welcome.SetActive(false);
    }
    public void eng()
    {
        xinchao.SetActive(false) ;
        welcome.SetActive(true) ;
        //videoPlayer.url = " ";
       
    }

}
