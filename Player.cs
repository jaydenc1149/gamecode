using UnityEngine;

public class Player: MonoBehaviour
{
    private int MaxHP;
    private int Atk;
    private int HP;
    private int Def;
    public static int playerLevel;
    public int Exp;
    Rigidbody rb;
    

    public Player(int MaxHitpoints, int Attack, int Hitpoints, int Defense, int Experience){
        MaxHP = MaxHitpoints;
        Atk = Attack;
        HP = Hitpoints; 
        Def = Defense;
        Exp = Experience;
    }
          

    public void HPToFull(){
        Debug.log("HP is maxed.");
        HP = MaxHP;
    }
    public void setMaxHP(int e){
        Debug.log("Max HP Increased");
        MaxHP = 50 + e;
    }
    public void lostHP(int d){
        Debug.log("HP has been lost");
        HP -= d;
    }

    public void gainHP(int h){
        HP += h;
        if (HP > MaxHP){
            HP = MaxHP;
        }
    }
    public void TotalAtkIncrease(int g){
        Atk = 5 + playerLevel + g;
    }

    public void DefIncrease(int f){
        def = f; 
    }
    
    public void TakeDamageSound(){ 
        // sound effect needed
        Debug.Log("Player took Damage sound");
    }
    public void GainHPSound(){
        // sound effect needed
        Debug.Log("Player got healed sound");
    }
    public void levelUp(){
        if (Exp = 20*playerLevel){
        playerLevel++;
        }
        Exp = 0;
    }
    
    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {

        

        
    }
    
}
