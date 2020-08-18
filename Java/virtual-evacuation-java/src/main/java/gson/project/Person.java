package gson.project;

import com.google.gson.Gson;

public class Person {
	public int ID;
	public String Xpos;
	public String Ypos;
	
	

	public int getID() {
		return ID;
	}

	public void setID(int iD) {
		ID = iD;
	}

	public String getXpos() {
		return Xpos;
	}

	public void setXpos(String xpos) {
		Xpos = xpos;
	}

	public String getYpos() {
		return Ypos;
	}

	public void setYpos(String ypos) {
		Ypos = ypos;
	}
	
	

	public Person(int ID, String Xpos, String Ypos) {
		ID=ID;
		Xpos=Xpos;
		Ypos=Ypos;
	}

	public Person() {
		// TODO Auto-generated constructor stub
	}

	public String toString() {
		return "Person [ ID:  + ID +  , Xpos:  + Xpos +  ,Ypos:  + Ypos +  ]";
	}

	public static Person Deserialize(String jsonString)
	{
		Gson gsonInstance = new Gson();
		Person result = gsonInstance.fromJson(jsonString, Person.class);
		return result;
	}
	
	public String Serialize()
	{
		Gson gsonInstance = new Gson();
		return gsonInstance.toJson(this);
	}

}
