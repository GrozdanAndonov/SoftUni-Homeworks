import java.util.Scanner;

public class secondLessonBMIcalculator {

	public static void main(String[] args) {
		for(int num=1;num<=100;num++){
		Scanner scanner=new Scanner(System.in);
		
		 printIntroduction();
		
		 reportResults(num,getBMI(scanner.nextDouble(),scanner.nextDouble()));
		
		
		}

	}

	
public static void printIntroduction(){
	System.out.println("BMI CALCULATOR");
	System.out.println("BMI калкулаторът пресмята вашият "
			+ "индекс по определена формула, спрямо теглото, "
			+ "което ще му подадете.");
	System.out.println("Enter height(inches) and weight(pounds):");
}
public static double getBMI(double heighINCH,double weightPND){
	
	double heighSM=heighINCH/ 0.3937; 
	double weightKG=weightPND/2.2046;
	
	//System.out.format("%.2f"+"cm heigh and "+"%.2f"+"kg weight.",heighSM,weightKG);
	
	 return bmiFor(heighSM,weightKG);
	
}
public static double  bmiFor(double height,double weight){
	
	double bmi=weight*703/ (height*height);
	
	return bmi;
}
public static void getStatus(double bmi){
	
	if(bmi<=18.5)
	{
		String str= "underweight";
		System.out.println(str);
	}else
	{
		if(bmi<= 25)
		{
			String str="normal";
			System.out.println(str);
		}else
		{
			if(bmi<=30)
			{
				String str="overweight";
				System.out.println(str);
			}else
			{
				if(bmi>30)
				{
					String str="obese";
					System.out.println(str);
				}
			}
		}
	}
}
public static void reportResults(int id,double bmiIndex){
	
	double bmi=Math.round(bmiIndex);
	System.out.println("Person with ID="+id+" and BMI="+bmi);
}


}
