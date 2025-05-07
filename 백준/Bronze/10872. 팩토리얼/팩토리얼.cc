#include <iostream>

using namespace std;

int main() {
    // 12까지의 낮은 팩토리얼 계산 문제
    // 추후 더 높은 숫자를 계산할 때에는 재귀+메모이제이션을 활용

    int n;
    cin >> n;

    int result = 1;

    for (int i = 1; i <= n; i++) {
        result *= i;
    }

    cout << result;
    
    return 0;
}