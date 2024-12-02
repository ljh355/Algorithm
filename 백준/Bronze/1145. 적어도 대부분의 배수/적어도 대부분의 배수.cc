#include <iostream>
using namespace std;

int main() {
    int arr[5] = {};

    int arrSize = sizeof(arr) / sizeof(int);
    
    for (int i = 0; i < arrSize; i++) {
        cin >> arr[i];
    }

    int result = 1;

    while(true) {
        int cnt = 0;
        
        for (int i = 0; i < arrSize; i++) {
            if (result % arr[i] == 0) {
                cnt++;
            }
        }

        if (cnt >= 3) {
            break;
        }
        
        result++;
    }

    cout << result << endl;
}