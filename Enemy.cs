using System;
public class Enemy { // base class
	// instance variables
	private int MaxHP;
	private int HP;
	private int Atk;
	private int Def;
	private string Pattern;
	private int Range;
	private bool Dead;
	
	
	public Enemy(int MaxHitpoints, int Hitpoints, int Attack, int Defense, string AttackPattern, int EngageRange, bool isDead){ // constructor
		MaxHP = MaxHitpoints;
		HP = Hitpoints;
		Atk = Attack;
		Def = Defense;
		Pattern = AttackPattern;
		Range = EngageRange;
		Dead = isDead;
	}


	// getter methods
	public int getMaxHP(){
		return MaxHP;
	}
	public int getHP(){
		return HP;
	}
	public int getDef(){
		return Def;
	}
	public int getAtk(){
		return Atk;
	}
	public void setMaxHP(int m){
		MaxHP = m;
	}
	public void loseHP(int h){
		HP = HP - h;
		if (HP <= 0){ // if enemy dies
			Dead = true;
		}
	}
	public void gainHP(int g){
		HP = HP + g;
		if (HP > MaxHP){ // set to max HP if HP goes over max
			HP = MaxHP;
		}
	}
	// setter methods
	public void setDef(int d){
		Def = d;
	}
	public void setAtk(int a){
		Atk = a;
	}
	public string getPattern(){
		return Pattern;
	}
	public void setPattern(string p){
		Pattern = p;
	}
	public void setRange(string p){
		if (p == "passive"){
			Range = 1;
		}
		if (p == "neutral"){
			Range = 7;
		}
		else{
			Range = 22;
		}
	}
	// sets enemy stats to 0
	public void EnemyDies(){
		if (Dead == true){
		MaxHP = 0;
		HP = 0;
		Atk = 0;
		Def = 0;
		Pattern = null;
		Range = 0;
			
		}
	}
		
          

	
}
