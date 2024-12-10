#include <bits/stdc++.h>
using namespace std;

int main() {
    // 백준 1059

    int l;
    vector<int> s;
    int n;
    int result = 0;
    int start = 0, end = 0;

    cin >> l;
    
    for (int i = 0; i < l; i++) {
        int temp;
        cin >> temp;
        s.push_back(temp);
    }

    cin >> n;

    sort(s.begin(), s.end());

    for (int i = 0; i < s.size() - 1; i++) {
        if (n > s[i]) {
            start = s[i] + 1;
            end = s[i+1] - 1;
        }
    }

    if (end < n) {
        start = 0;
        end = 0;
    }

    if (n < s[0]) {
        start = 1;
        end = s[0] - 1;
    }

    // start~end 중 n를 포함하는 수 검증 필요
    for (int i = start; i <= end; i++) {
        for (int j = end; j >= start; j--) {
            if ((i <= n) && (j >= n) && (i != j)) {
                result++;
            }
        }
    }

    cout << result;
    
    return 0;
}