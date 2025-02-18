#include <iostream>
using namespace std;

int cal(int k, int n) {
    if (k == 0 || n == 1) {
        return n;
    } else {
        return cal(k-1, n) + cal(k, n-1);
    }
}

int main() {
    int t, k, n;
    cin >> t;
    
    for (int i = 0; i < t; i++) {
        cin >> k >> n;
        cout << cal(k, n) << endl;
    }
    
    return 0;
}