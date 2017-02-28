import java.util.Scanner;

public class firstLessonFirstTask {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		
		String[] names=new String[3];
		System.out.println("Enter your names:");
		for(int num=0;num<names.length;num++)
		{
		   names[num]=scanner.next();
		}
			System.out.println("Enter your years:");
			byte age=scanner.nextByte();
			
			System.out.println("Enter day of birth(num):");
			byte dayOfBirth=scanner.nextByte();
			System.out.println("Enter month of birth(num):");
			byte month=scanner.nextByte();
			System.out.println("Enter year of birth(year):");
			short year=scanner.nextShort();
			
			for(int num=0;num<names.length;num++)
			{
				System.out.print(names[num]+ " ");
			}
			System.out.print(age+" ");
			System.out.print(dayOfBirth+"."+month+"."+year);
			
}
}