# JsonClassGenerator

***
### 개요

Json 형식문자열을 입력받아 같은 형식의 Json 데이터를 파싱하여 담을 수 있는 C# 클래스 코드를 생성해주는 어플리케이션

***
### 요구사항  
.Net FramWork 4.6.1 이상

***
### 사용법
![jc1](https://user-images.githubusercontent.com/34447880/40353748-310449e2-5ded-11e8-8943-f0c264d00881.PNG)
1. 'Json 문자열' TextBox에 원하는 Json 형식 문자열을 입력합니다.
2. 멤버로 Property / Field 선언을 선택합니다. (둘다 선택가능, 형식 편집가능)
3. '생성' 버튼을 누르면 클래스 코드를 만들어 줍니다. 
4. 좌측하단 TreeView 에서 입력 Json 문자열에 포함된 Object형식을 나타내는 계층도를 볼 수 있습니다.
   노드를 클릭하여 클래스 코드를 선택하고 해당 Object의 클래스 코드를 볼 수 있습니다.
5. '클래스명 바꾸기' 버튼으로 선택한 클래스의 이름 변경이 가능합니다.
6. 생성된 코드를 복사하여 사용하거나, '파일생성' 버튼으로 지정된 경로에 .cs 형식 파일로 저장 할 수 있습니다. (네임스페이스를 지정)

***
- 생선된 cs파일 

![jc3](https://user-images.githubusercontent.com/34447880/40354697-6e0aa3d4-5def-11e8-80bb-80a57685226f.PNG)
![jc4](https://user-images.githubusercontent.com/34447880/40354680-67f0965c-5def-11e8-9515-40e3058d3732.PNG)
