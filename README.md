# JsonClassGenerator

***
### 개요

Json 형식문자열을 입력받아 같은 형식의 Json 데이터를 파싱하여 담을 수 있는 C# 클래스 코드를 생성해주는 어플리케이션

***
### 요구사항  
.Net FramWork 4.6.1 이상

***
### 사용법
![jc5](https://user-images.githubusercontent.com/34447880/40582420-31902f44-61b1-11e8-96ea-0f8f7286bff0.PNG)
1. 'Json 문자열' TextBox에 원하는 Json 형식 문자열을 입력합니다.
2. 멤버로 Property / Field 선언을 선택합니다. (둘다 선택가능, 형식 편집가능)
3. '생성' 버튼을 누르면 클래스 코드를 만들어 줍니다. 
4. 좌측하단 TreeView 에서 입력 Json 문자열에 포함된 Object형식을 나타내는 계층도를 볼 수 있습니다.
   노드를 클릭하여 클래스 코드를 선택하고 해당 Object의 클래스 코드를 볼 수 있습니다.
5. '클래스명 바꾸기' 버튼으로 선택한 클래스의 이름 변경이 가능합니다.
6. 생성된 코드를 복사하여 사용하거나, '파일생성' 버튼으로 지정된 경로에 .cs 형식 파일로 저장 할 수 있습니다. (네임스페이스를 지정)

***
### 생선된 cs파일 

![jc6](https://user-images.githubusercontent.com/34447880/40582426-a7cfc642-61b1-11e8-82ee-75b48105582e.PNG)
![jc7](https://user-images.githubusercontent.com/34447880/40582427-a7fadbf2-61b1-11e8-8b11-65f18510b468.PNG)
![jc8](https://user-images.githubusercontent.com/34447880/40582418-3130632a-61b1-11e8-96e6-fbc401755c11.PNG)
![jc9](https://user-images.githubusercontent.com/34447880/40582419-3160a3b4-61b1-11e8-9dc7-b7866739ddcb.PNG)

***
### 주의사항
1. 중첩 Array가 포함되면 제대로 작동안합니다.  
2. 여러 타입의 클래스가 포함된 Array가 있다면  JObject를 받는 생성자에서 제대로 초기화하지 않습니다. 따로 데이터를 파싱하세요  
4. Array나 Object 타입 변수들은 null 처리가 제대로 안될 수 있습니다.  
