/*
	Johnathan R. Burgess, 11/06/2018
*/
#include <iostream>

using namespace std;

int main(){
	
	int TF[5];

	int A[] = {1,2,3,4,5,6,76,35,7,8,9,11,12,15,20};

	int S[] = {23,10,11,7,3,18};

	int x = 3;

	for(int a = 0; a < 6; a++){
		for(int b = 0; b < 15; b++){
			if(x+A[b]==S[a]){
				TF[a] = S[a];
				break;
			}else{
				TF[a] = 0;
			}
		}

	}

	for(int c = 0; c < 6; c++){
		cout << TF[c] << endl;
	}

	return 0;

}
