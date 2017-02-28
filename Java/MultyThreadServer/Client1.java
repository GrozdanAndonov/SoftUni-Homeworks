import java.io.IOException;
import java.io.PrintStream;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;

public class Client1 {

	public static void main(String[] args) throws UnknownHostException, IOException {
		
		Socket connection=new Socket("127.0.0.1",1234);
		Scanner scanner=new Scanner(System.in);
		Scanner scanner2=new Scanner(connection.getInputStream());
		PrintStream printToThem=new PrintStream(connection.getOutputStream());
		System.out.println("You have connected to "+connection.getInetAddress().getHostAddress());
		System.out.println(scanner2.nextLine());
			
			int choice=scanner.nextInt();///1 or 2 choice
			printToThem.println(choice);
			printToThem.flush();
			if(choice==1){
			System.out.println(scanner2.nextLine());
			choice=scanner.nextInt();
			printToThem.print(choice);
			printToThem.flush();
			
			for (int i = 0; i <=choice; i++) {
				String text=scanner.nextLine();
				printToThem.println(text);
				printToThem.flush();
			}
			}else if(choice==2){
				while(scanner2.hasNext()){
				String text=scanner2.nextLine();
				System.out.println(text);
				}
			}
			
			connection.close();
			System.out.println("Ended the connection!");
			scanner2.close();
			scanner.close();
			printToThem.close();
	}

}
