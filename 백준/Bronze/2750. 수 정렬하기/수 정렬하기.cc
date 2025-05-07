#include <iostream>
#include <algorithm>

using namespace std;

int main() {
    // 1번 풀이 : 내장 sort 이용
    
    int n;
    cin >> n;
    vector<int> arr;

    for (int i = 0; i < n; i ++) {
        int temp;
        cin >> temp;
        arr.push_back(temp);
    }

    sort(arr.begin(), arr.end());

    for (int i = 0; i < arr.size(); i++) {
        cout << arr[i] << endl;
    }
    
    return 0;
}