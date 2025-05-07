#include <iostream>

using namespace std;

int main() {
    // 소수 판별은 에라토스테네스의 체를 활용할 수 있는 문제
    // 하지만 기본 형태이기에 단순 반복문으로 해결할 수 있는 방법으로 연습
    
    int n, result = 0;
    cin >> n;
    int arr[n];

    for (int i = 0; i < n; i++) {
        cin >> arr[i];

        for (int j = 2; j <= arr[i]; j++) {
            if (j == arr[i]) {
                result++;
            } else {
                if (arr[i] % j == 0) {
                    break;
                }
            }
        }
    }

    cout << result;
    
    return 0;
}