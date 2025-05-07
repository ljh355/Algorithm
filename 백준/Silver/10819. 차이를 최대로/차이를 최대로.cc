#include <iostream>
#include <algorithm>

using namespace std;

static int maxValue = 0;

// 스왑을 이용한 순열 계산 함수
void permutation(vector<int> arr, int start, int end) {
    if (start == end) {
        int temp = 0;
        for (int i = 0; i < arr.size()-1; i++) {
            temp += abs(arr[i] - arr[i+1]);
        }
        if (temp > maxValue) maxValue = temp;
        return;
    }

    for (int i = start; i < end; i++) {
        swap(arr[i], arr[start]);
        permutation(arr, start+1, end);
        swap(arr[i], arr[start]);
    }

    return;
}

int main() {
    int n;
    cin >> n;
    vector<int> arr;

    for (int i = 0; i < n; i++) {
        int temp;
        cin >> temp;
        arr.push_back(temp);
    }

    permutation(arr, 0, n);

    cout << maxValue;
    
    return 0;
}