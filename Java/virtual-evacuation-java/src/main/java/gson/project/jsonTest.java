package gson.project;

import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.PrintWriter;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.Socket;
import java.util.Scanner;

/*import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.Socket;
import java.util.Scanner;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonElement;*/

public class jsonTest /*implements Serializable*/ {
	public static void main(String args[]) {

		//jsonTest tester = new jsonTest();
		try {

//			
//			
			//==========================================
			
			Person person = new Person();
			person.setID(1);
			person.setXpos("xpos");
			person.setYpos("ypos");
			

			
			
			
			String personString = person.Serialize();
			personString = personString + "\r\n";
			System.out.println(personString);
			Person myPerson = Person.Deserialize(personString);
			System.out.println(myPerson.ID);
			
        	byte [] buffer = personString.getBytes();
			//first method
        	
//			Scanner sc=new Scanner(System.in);
//			System.out.println("enter somethinig");
//			String input=sc.nextLine();
//			
//			byte [] buffer =input.getBytes();
			//socket connection
//			
//			DatagramSocket sck = new DatagramSocket();
//			InetAddress address =InetAddress.getByName("localhost");
//			
//			DatagramPacket packets= new DatagramPacket(buffer, buffer.length,address,8888);
//			sck.send(packets);
			
		
        	
        	//second method
			
			Socket socketConnection = new Socket("127.0.0.1", 8888);
			
			ObjectOutputStream clientOutputStream = new ObjectOutputStream(socketConnection.getOutputStream());
			clientOutputStream.writeObject(buffer);
			
			clientOutputStream.close();
			

			
			

		} 
		/*catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}*/
		catch (Exception e)
		{
			e.printStackTrace();
		}
	}

	/*// Serialization
	private void serialize(Person person) throws IOException {
		GsonBuilder builder = new GsonBuilder();
		Gson gson = builder.create();
		FileWriter writer = new FileWriter("person.json");
		writer.write(gson.toJson(person));

		writer.close();
	}

	// deSerialization
	private Person deserialize() throws FileNotFoundException {
		GsonBuilder builder = new GsonBuilder();
		Gson gson = builder.create();
		BufferedReader bufferedReader = new BufferedReader(new FileReader("person.json"));

		Person person = gson.fromJson(bufferedReader, Person.class);
		return person;
	}*/
}
