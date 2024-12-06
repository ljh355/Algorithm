#include <bits/stdc++.h>
using namespace std;

int main() {
    // 백준 1817
    // 스택 형식의 문제
    
    int n;
    int m;
    stack<int> books;

    int weightSum = 0;
    int boxCnt = 0;

    cin >> n >> m;

    for (int i = 0; i < n; i++) {
        int temp;
        cin >> temp;
        books.push(temp);
    }

    // m에 box 카운트를 재며 사용
    while(!books.empty()) {
        weightSum += books.top();

        if (weightSum > m) {
            weightSum = books.top();
            boxCnt++;
        } else if (weightSum == m) {
            weightSum = 0;
            boxCnt++;
        }
        
        books.pop();
    }

    if (weightSum != 0) boxCnt++;

    cout << boxCnt;
    
    return 0;
}