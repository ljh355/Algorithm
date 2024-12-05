#include <bits/stdc++.h>
using namespace std;

int main() {
    // 백준 2441

    int n;
    cin >> n;

    for (int i = 0; i < n; i++) {
        int gap = i;
        int star = n - i;

        while (gap > 0) {
            cout << " ";
            gap--;
        }

        while (star > 0) {
            cout << "*";
            star--;
        }

        if (i != n - 1) {
            cout << endl;
        }
    }
    
    return 0;
}