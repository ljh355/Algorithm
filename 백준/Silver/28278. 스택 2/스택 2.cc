#include <iostream>
#include <stack>
#include <string>
using namespace std;

int main() {
	ios_base::sync_with_stdio(false); // c++과  c의 표준 스트림 동기화를 끊어주는 역할 (c에서 사용하던 입출력 사용하면 안 됨)
	cin.tie(NULL); // cin, cout은 묶여있어 출력 후의 입력이 이루어지는데 이걸 풀어주는 작업. 다만 개발에서 사용 시 cout 요구 전 입력이 가능하다.
    
    int n;
    cin >> n;
    cin.ignore();

    stack<string> s;

    for (int i = 0; i < n; i++) {
        string str;
        getline(cin, str);
        
        char command = str[0];

        if (command == '1') { // x를 스택에 넣기
            s.push(str.substr(2));
        } else if (command == '2') { // 정수 있으면 맨 위 정수 빼고 출력. 없으면 -1
            if (s.empty()) {
                cout << -1 << "\n"; // endl의 경우, flush의 출력 버퍼를 지우는 역할을 하기에 시간 소요가 많으므로 대체
            } else {
                cout << s.top() << "\n";
                s.pop();
            }
        } else if (command == '3') { // 스택의 정수의 개수 출력
            cout << s.size() << "\n";
        } else if (command == '4') { // 스택이 비어있으면 1, 아니면 0 출력
            cout << (s.empty() ? 1 : 0) << "\n";
        } else if (command == '5') { // 스택에 정수가 있다면 맨 위의 정수를 출력, 없으면 -1
            if (s.empty()) {
                cout << -1 << "\n";
            } else {
                cout << s.top() << "\n";
            }
        }
    }
    
    return 0;
}
