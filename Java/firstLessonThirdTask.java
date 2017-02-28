import java.util.Scanner;

public class firstLessonThirdTask {

	public static void main(String[] args) {
		System.out.println("Write 5 strings:");
		Scanner scanner=new Scanner(System.in);

		String[] strings=new String[5];
		
		for(byte num=0;num<strings.length;num++)
		{
			strings[num]=scanner.next();
		}
		
		for(byte num=0;num<strings.length;num++)
		{
			System.out.println(strings[num]);
		}		
	}
}
