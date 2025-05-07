import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int N = sc.nextInt();
		
		int cnt = 0;
		
		for (int i=0; i<N; i++) {
			int tmp = sc.nextInt();
			
			if (tmp==2) cnt++;
			
			for (int j=2; j<tmp; j++) {			
				if (tmp%j == 0) {
					break;
				}
				if (j==tmp-1) {
					cnt++;
				}
			}
		}
		System.out.println(cnt);
	}
}