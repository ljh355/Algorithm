#include <iostream>
using namespace std;

int main() {
    int arr[101][101] = {0}; // 쓰레기값 안가지게 주의
    int x1, x2, y1, y2;
    int result = 0;
    for (int i = 0; i < 4; i++) {
        cin >> x1 >> y1 >> x2 >> y2;

        for (int j = x1; j < x2; j++) {
            for (int k = y1; k < y2; k++) {
                arr[j][k] = 1;
            }
        }
    }

    for (int i = 0; i < 101; i++) {
        for (int j = 0; j < 101; j++) {
            if (arr[i][j] == 1) {
                result++;
            }
        }
    }

    cout << result;
    
    return 0;
}