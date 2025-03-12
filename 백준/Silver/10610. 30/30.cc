#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

int main() {

    // 백준 10610
    // 배수 판정법을 활용 (30 = 3*10)
    // 3의 배수 -> 모든 자리 수의 합이 3의 배수
    // 10의 배수 -> 일의 자리가 0
    
    vector<int> v;
    string n;

    int threeChecker = 0; // 3의 배수 판별을 위한 카운터

    cin >> n;

    for (int i = 0; i  < n.size(); i++) {
        v.push_back(n[i] - '0');
        threeChecker += n[i] - '0';
    }

    sort(v.rbegin(), v.rend()); // 내림차순 정렬

    // 모든 자리 수의 합이 3으로 나누어떨어지고, 벡터의 마지막 원소가 0이면 30의 배수
    if ((threeChecker % 3 == 0) && (v.back() == 0)) {
        for (int num : v) {
            cout << num;
        }
    } else {
        cout << -1;
    }

    return 0;
}