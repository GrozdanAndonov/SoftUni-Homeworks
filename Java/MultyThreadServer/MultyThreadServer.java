import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

public class MultyThreadServer implements Runnable{
	Socket connection;
	public MultyThreadServer(Socket connection){
		this.connection=connection;
	}
	@SuppressWarnings({ "unused", "resource" })
	public static void main(String[] args) {	
		try{
		ServerSocket server= new ServerSocket(1234);
		Socket socket = null;
		System.out.println("Listening...");
		Scanner scanner=new Scanner(System.in);
		while(true){
			 socket= server.accept();
			 PrintStream printToThem=new PrintStream(socket.getOutputStream());
			 Scanner scanner2=new Scanner(socket.getInputStream());
			System.out.println("Connected to "+socket.getInetAddress().getHostAddress());
			new Thread(new MultyThreadServer(socket)).start();
		}
	}catch(IOException e){
		System.out.println("The port is used by another program!");
	}
	}

	public void run(){
		try{
		PrintStream printToThem=new PrintStream(connection.getOutputStream());
		Scanner scanner=new Scanner(System.in);
		Scanner scanner2=new Scanner(connection.getInputStream());
		printToThem.println("Pri vuvejdane vuvedete 1, pri chetene ot file 2:");
		int choice=scanner2.nextInt();
		System.out.println(choice);
		if(choice==1){
			int buffSize=5*1024;
			BufferedWriter buffWrite=new BufferedWriter(new FileWriter("C:\\Users\\Grozdan\\Desktop\\textFile.txt"),buffSize);
			printToThem.println("How many rows you want to enter?");
			int rows=scanner2.nextInt();
			printToThem.println("Start writting:");
			for (int i = 0; i <=rows; i++) {
			String text=scanner2.nextLine();
			buffWrite.write(text);
			if(!(i==0)){
			buffWrite.newLine();
			}
			buffWrite.flush();
			}
			
			
			printToThem.close();
			buffWrite.close();
			scanner.close();
			scanner2.close();
		}else if(choice==2){
			
			BufferedReader buffRead=new BufferedReader(new FileReader("C:\\Users\\Grozdan\\Desktop\\textFile.txt"));
			
			if(!(buffRead.ready())){
				printToThem.println("The file is empty!");
			}else{
			do{
				printToThem.println(buffRead.readLine());
				printToThem.flush();
			}while(buffRead.ready());
			printToThem.println("End of file!");
			buffRead.close();
		}
		}
		
	scanner2.close();
	connection.close();
	System.out.println("Ended the connection!");
		}catch(Exception e){
			e.printStackTrace();
		}
		
	}
	
}
