# JsonClassGenerator

***
### 개요

Json 형식문자열을 입력받아 같은 형식의 Json 데이터를 파싱하여 담을 수 있는 C# 클래스 코드를 생성해주는 어플리케이션

***
### 요구사항  
.Net FramWork 4.6.1 이상

***
### 사용법
![jc2_1](https://user-images.githubusercontent.com/34447880/42551004-ecd6d34e-850f-11e8-8ffd-7a1a1bde0d03.PNG)
1. 'Json 문자열' TextBox에 원하는 Json 형식 문자열을 입력합니다.
2. 우측에서 필드 옵션을 고릅니다. 
   '사용자지정 필드 형식'을 사용하면 사용자가 입력한 형식으로 필드를 생성합니다. 
3. 클래스와 파일 코드의 형태는 '템플릿 설정' 으로 변경 가능합니다. (규칙은 아래에)
3. '생성' 버튼을 누르면 클래스 코드를 만들어 줍니다. 
4. 좌측하단 TreeView 에서 입력 Json 문자열에 포함된 Object형식을 나타내는 계층도를 볼 수 있습니다.
   노드를 클릭하여 클래스 코드를 선택하고 해당 Object의 클래스 코드를 볼 수 있습니다.
5. '클래스명 바꾸기' 버튼으로 선택한 클래스의 이름 변경이 가능합니다.
6. 생성된 코드를 복사하여 사용하거나, '파일생성' 버튼으로 지정된 경로에 .cs 형식 파일로 저장 할 수 있습니다. (네임스페이스를 지정)

***
### 생선된 cs파일 

![jc2_6](https://user-images.githubusercontent.com/34447880/42556236-ed0a861a-8525-11e8-8118-02670db073f3.PNG)
![jc2_7](https://user-images.githubusercontent.com/34447880/42556237-ed3942fc-8525-11e8-8ed4-3fb0f5afe24d.PNG)
![jc2_8](https://user-images.githubusercontent.com/34447880/42556239-ed69783c-8525-11e8-9b90-da9f1e151e0a.PNG)
![jc2_9](https://user-images.githubusercontent.com/34447880/42556242-ed9f2ad6-8525-11e8-92b6-e8bb3578a31a.PNG)

***
### 템플릿 규칙
1. 필드 템플릿 (사용자 지정 필드 형식)  
   {NAME} : 필드의 이름  
   {TYPE} : 필드의 자료형  
   
   "Name" : "이름" / public {TYPE} {NAME} { get; set;} => public string Name { get; set; }
   
2. 클래스 템플릿  
   {CN} : 클래스 이름  
   {FD} : 필드가 자리하는 위치  
   
   [JsonObject(MemberSerialization.OptOut)]  
   class {CN}  
   {  
       &nbsp;&nbsp;&nbsp;#region Fields  
	    &nbsp;&nbsp;&nbsp;{FD}     
       &nbsp;&nbsp;&nbsp;#endregion  
   }  
    
   //----------------------------------------//  
     
   [JsonObject(MemberSerialization.OptOut)]  
   class Book  
   {  
       &nbsp;&nbsp;&nbsp;#region Fields  
	    &nbsp;&nbsp;&nbsp;public string Name  {get; set;}  
	    &nbsp;&nbsp;&nbsp;public Data Data  {get; set;}  
	    &nbsp;&nbsp;&nbsp;public List<string> Friends  {get; set;}  
	    &nbsp;&nbsp;&nbsp;public List<BookInfo> Books  {get; set;}      
	    &nbsp;&nbsp;&nbsp;#endregion  
   }  
    
3. 파일 템플릿  
   {NS} : 네임스페이스  
   {CC} : 클래스 코드  
   
   using System.Collections.Generic;  
   using Newtonsoft.Json.Linq;  
   using Newtonsoft.Json;  

   namespace {NS}  
   {  
      &nbsp;&nbsp;&nbsp;{CC}  
   }  
   
   //---------------------------------------//  
   
   using System.Collections.Generic;  
   using Newtonsoft.Json.Linq;  
   using Newtonsoft.Json;  

   namespace Test  
   {  
	   &nbsp;&nbsp;&nbsp;class Book    
      &nbsp;&nbsp;&nbsp;{   
      &nbsp;&nbsp;&nbsp;#region Fields  
	   &nbsp;&nbsp;&nbsp;public string Name  {get; set;}  
	   &nbsp;&nbsp;&nbsp;public Data Data  {get; set;}  
	   &nbsp;&nbsp;&nbsp;public List<string> Friends  {get; set;}  
	   &nbsp;&nbsp;&nbsp;public List<BookInfo> Books  {get; set;}      
	   &nbsp;&nbsp;&nbsp;#endregion  
      &nbsp;&nbsp;&nbsp;}  
   }  

템플릿 파일은 .nmt 형식 으로 저장해 주세요
***
### 주의사항
1. 중첩 Array가 포함되면 제대로 작동안합니다.  
2. 여러 타입의 클래스가 포함된 Array가 있다면  JObject를 받는 생성자에서 제대로 초기화하지 않습니다. 따로 데이터를 파싱하세요  
3. Array나 Object 타입 변수들은 null 처리가 제대로 안될 수 있습니다.  

* 클래스 코드를 만드는 부분은 별도의 프로젝트(클래스 라이브러리)로 되어있습니다.
