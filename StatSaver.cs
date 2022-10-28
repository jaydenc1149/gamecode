using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;

class StatSaver{
	public static void ReadLine(){
	 int variable = 1;
    //Pass file path and name to reader
    StreamReader sr = new StreamReader("playerSave.txt");
    // Read the first line of text
    String line = sr.ReadLine();
			  // loop for each variable within the player object as long as the next line isn't blank
    while (line != null)
    {
        switch(variable){
            case 1:
                Player.setPL(int.Parse(sr.ReadLine()));
                break;
            case 2:
                Player.setExp(int.Parse(sr.ReadLine()));
                break;
            case 3: 
                Player.setHP(int.Parse(sr.ReadLine()));
                break;
            case 4: 
                Player.setMaxHP(int.Parse(sr.ReadLine()));
                break;
            case 5: 
                Player.setAtk(int.Parse(sr.ReadLine()));
                break;
            case 6: 
                Player.setDef(int.Parse(sr.ReadLine()));
                break;
            default:
                break;
        }
        variable++;
			// read the next line
			line = sr.ReadLine();
    }
    sr.Close();
	}
	
	public static async Task WriteText(){
		String s;
  	string[] numbers = new string[6];
		for (int i = 0; i < numbers.Length;i++){
			switch (i){
				case 0:
					s = Player.getExp().ToString();
					numbers[i] = s;
					break;
				case 1:
					s = Player.getExp().ToString();
					numbers[i] = s;
					break;
				case 2:
					s = Player.getExp().ToString();
					numbers[i] = s;
					break;
				case 3:
					s = Player.getExp().ToString();
					numbers[i] = s;
					break;
				case 4:
					s = Player.getExp().ToString();
					numbers[i] = s;
					break;
				case 5:
					s = Player.getExp().ToString();
					numbers[i] = s;
					break;
					
			}
		}

		await File.WriteAllLinesAsync("playerSave.txt", numbers);
		 
		
		
			}
}
