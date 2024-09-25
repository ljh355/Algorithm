#include <string>
#include <vector>

using namespace std;

string solution(string video_len, string pos, string op_start, string op_end, vector<string> commands) {
    // 동영상 재생기의 기능 : 10초 전 이동, 10초 후 이동, 오프닝 건너뛰기
    // prev : 10초 전 이동, 현재 위치가 10초 미만인 경우 처음 위치로 이동
    // next : 10초 후 이동, 동영상의 남은 시간이 10초 미만일 경우 마지막 위치 (동영상의 길이)
    // op_start <= 현재 재생 위치 <= op_end인 경우 오프닝이 끝나는 위치로 이동하는 것이 오프닝 건너뛰기
    // 매개변수 : (순서대로) 동영상의 길이, 기능 수행되기 직전의 재생위치, 오프닝 시작 시각, 오프닝 끝나는 시각, 사용자의 입력인 1차원 배열
    // return : "mm:ss"
    
    // 1. 반복문을 통해 commands를 하나씩 실행시킨다.
    // 2. 현재 재생 위치가 오프닝 위치인지 검증한다. (for문의 시작 부분과 for문이 종료된 후 마지막에 한 번 더 검사하면 검증 완료)
    // 3. next 버튼인 경우, 10초를 증가시킨다. 만약, 10을 증가시킨 수치가 video_len보다 크다면 answer는 video_len으로 할당한다.
    // 4. prev 버튼인 경우, 10초를 감소시킨다. 만약, 10을 감소시킨 수치가 "00:00"보다 작다면 answer는 "00:00"으로 할당한다.
    // 수치의 계산은 그냥 int형의 임시변수 하나로 사용? -> 근데 코드가 더럽긴하네..
    
    string answer = pos;
    
    int tmpTime = 0;
    int videoEndTime = stoi(video_len.substr(0,2)) * 60 + stoi(video_len.substr(3,2));
    
    for (int i=0; i<commands.size(); i++)
    {
        if ((answer >= op_start) && (answer <= op_end))
        {
            answer = op_end;
        }
        
        tmpTime = stoi(answer.substr(0,2)) * 60 + stoi(answer.substr(3,2));
        
        if (commands[i] == "next")
        {
            tmpTime += 10;
            if (videoEndTime <= tmpTime)
            {
                tmpTime = videoEndTime;
            }
        }
        else if (commands[i] == "prev")
        {
            tmpTime -= 10;
            if (0 >= tmpTime)
            {
                tmpTime = 0;
            }
        }
        
        answer = "";
        
        if (tmpTime/60 < 10)
        {
            answer += "0";
        }
        answer += to_string(tmpTime/60) + ":";
        
        if (tmpTime%60 < 10)
        {
            answer += "0";
        }
        answer += to_string(tmpTime%60);
    }
    
    if ((answer >= op_start) && (answer <= op_end))
    {
        answer = op_end;
    }
    
    return answer;
}