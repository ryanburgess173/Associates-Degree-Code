package ryan;

public class arrays {
	public static void main(String[] args) {
		int month_days[];
		month_days = new int[12];
		month_days[0] = 31;
		month_days[1] = 28;
		month_days[2] = 31;
		month_days[3] = 30;
		month_days[4] = 31;
		month_days[5] = 30;
		month_days[6] = 31;
		month_days[7] = 31;
		month_days[8] = 30;
		month_days[9] = 31;
		month_days[10] = 30;
		month_days[11] = 31;
		System.out.println("April has " + month_days[3] + " days.");
		
		int months[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		System.out.println("April has " + months[3] + " days.");
		
		double nums[] = {10.1, 11.2, 12.3, 13.4, 14.5};
		double result = 0;
		int i;
		for(i=0; i<5; i++) {
			result = result + nums[i];
			System.out.println("average is "+result/5);
		}
		
		// Multi-dimensional array stuff
		int twoD[][] = new int[4][5];
		int a,b,c = 0;
		
		for(a=0; a<4; a++) {
			for(b=0; b<5; b++) {
				twoD[a][b] = c;
				c++;
			}
		}
		
		for(a=0; a<4; a++) {
			for(b=0; b<5; b++) {
				System.out.print(twoD[a][b]+ " ");
			}
			System.out.println();
		}
		
		//Manually allocate differing size second dimensions
		int twoE[][] = new int[4][];
		twoE[0] = new int[1];
		twoE[1] = new int[2];
		twoE[2] = new int[3];
		twoE[3] = new int[4];
		
		int d,e,f = 0;
		for(d=0; d<4; d++)
			for(e=0; e<d+1; e++) {
				twoE[d][e] = f;
				f++;
		}
		for(d=0; d<4; d++) {
			for(e=0; e<d+1; e++)
					System.out.print(twoE[d][e] + " ");
			System.out.println();
		}
		
	}
}
