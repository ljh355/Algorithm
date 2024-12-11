#include <bits/stdc++.h>
using namespace std;

int leapYearChecker(int year) {
    if (year % 400 == 0) {
        // 윤년
        return 366;
    } else if (year % 100 == 0) {
        // 평년
        return 365;
    } else if (year % 4 == 0) {
        // 윤년
        return 366;
    } else {
        // 평년
        return 365;
    }
}

int monthChecker(int year, int month) {
    int daysMonth[] = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    int result = 0;

    if (leapYearChecker(year) == 366) {
        daysMonth[2] = 29;
    }

    for (int i = 1; i < month; i++) {
        result += daysMonth[i];
    }

    return result;
}

int main() {
    // 백준 1308

    vector<int> toDay;
    vector<int> dDay;

    for (int i = 0; i < 3; i++) {
        int temp;
        cin >> temp;
        toDay.push_back(temp);
    }

    for (int i = 0; i < 3; i++) {
        int temp;
        cin >> temp;
        dDay.push_back(temp);
    }
    
    if (dDay[0] - toDay[0] >= 1001) {
        cout << "gg";
    } else if ((dDay[0] - toDay[0] == 1000) && ((dDay[1] > toDay[1]) || ((dDay[1] == toDay[1]) && (dDay[2] >= toDay[2])))) {        
        cout << "gg";
    } else {
        int sum = 0;

        // 사이에 존재하는 년도만큼 결과값에 더함
        for (int i = toDay[0] + 1; i < dDay[0]; i++) {
            sum += leapYearChecker(i);
        }

        // year이 같은 경우
        if (dDay[0] == toDay[0]) {
            sum += (monthChecker(dDay[0], dDay[1]) + dDay[2]) - (monthChecker(toDay[0], toDay[1]) + toDay[2]);
        } else {
            // toDay의 이후 기간
            sum += leapYearChecker(toDay[0]) - (monthChecker(toDay[0], toDay[1]) + toDay[2]);
            // dDay의 이전 기간
            sum += monthChecker(dDay[0], dDay[1]) + dDay[2];
        }
        
        cout << "D-" << sum;
    }
    
    return 0;
}