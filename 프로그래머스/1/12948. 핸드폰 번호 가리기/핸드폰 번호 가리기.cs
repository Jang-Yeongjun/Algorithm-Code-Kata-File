public class Solution 
{
    public string solution(string phone_number) 
    {
        // 전화번호의 길이를 계산
        int length = phone_number.Length;
        
        // 전화번호의 뒷 4자리를 제외한 나머지 부분을 '*'로 가림
        string maskedPart = new string('*', length - 4);
        
        // 전화번호의 뒷 4자리를 추출
        string lastFourDigits = phone_number.Substring(length - 4);
        
        // 나머지 부분과 뒷 4자리를 합쳐서 결과를 반환
        string answer = maskedPart + lastFourDigits;
        
        return answer;
    }
}