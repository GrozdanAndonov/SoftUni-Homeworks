import java.util.ArrayList;
import java.util.Comparator;
import java.util.LinkedList;
import java.util.Map;
import java.util.Queue;
import java.util.Scanner;
import java.util.TreeMap;

public class Lists {

	public static void main(String[] args) {
		
		LinkedList<String> list=new LinkedList<String>();
		list.add("Grozdan");
		list.add("Kostadinov");
		list.add("Andonov");
		for(int num=0;num<list.size();num++){
		System.out.println(list.get(num));
		}

		ArrayList<String> names=new ArrayList<String>();
		
		names.add("Grozdan");
		names.add("Kostadinov");
		names.add("Andonov");
		names.add(3, "9503300048");
		System.out.println(names.get(3));
		
		Queue<String> queue=new LinkedList<String>();
		
		queue.add("Grozdan");
		queue.add("Kostadinov");
		queue.add("Andonov");
		System.out.println(queue.poll());
		
		final String text="Test some words here"+" Here words some";
		Map<String,Integer> wordsCounts=createWordsCounts(text);
		printWordsCount(wordsCounts);
		Map<String,Integer> words= new TreeMap<String,Integer>(caseInsensitiveComparator);
	}
		
		private static Map<String,Integer> createWordsCounts(String text){
			
			Scanner scanner=new Scanner(text);
			Map<String,Integer> words=new TreeMap<String,Integer>();
			while(scanner.hasNext()){
				String word=scanner.next();
				Integer count=words.get(word);
				if(count==null){
					count=0;
				}
				words.put(word, count+1);
			}
			return words;
		}
		
		private static void printWordsCount(Map<String,Integer> wordsCounts){
			for(Map.Entry<String, Integer> wordEntry:wordsCounts.entrySet()){
				System.out.printf("Word %s is seen %d times int the text%n",wordEntry.getKey(),wordEntry.getValue());
			}
		}
		static Comparator<String>caseInsensitiveComparator=new Comparator<String>(){
			
				@Override
				public  int compare(String o1,String o2){
					return o1.compareToIgnoreCase(o2);
				}
			
		};
		
		
		
		
		
		
		
		
		}


