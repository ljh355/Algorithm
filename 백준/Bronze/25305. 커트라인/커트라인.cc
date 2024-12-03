#include <bits/stdc++.h>
using namespace std;

int main() {
    // 백준 25305
    int n;
    int k;
    cin >> n >> k;
    
    vector<int> arr(n);
    
    for (int i = 0; i < n; i++) {
        cin >> arr[i];
    }

    sort(arr.begin(), arr.end());

    cout << arr[arr.size() - k];
    
    return 0;
}