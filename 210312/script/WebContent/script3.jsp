<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%--
	선언문(declaration) : <%! %> - 전역변수 선언, 메서드 선언
	스트립틀릿(scriptlet) : <% %> - 지역변수, 일반 루틴
	표현식(expression) : <%= %> - 화면 출력(변수, 메서드 호출) 
 --%>    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
		String str2 = "홍길동";
	%>
	<%!
		String str = "전역 변수";
	%>
	
	<%!
		String getStr() {
			return str;
		}
	%>
	<!-- html 주석
	<h1>전역변수 : <%=str %></h1> -->	
	<%-- jsp 주석
	<h2>메서드 호출 : <%=getStr() %></h2> --%>
	<h3><%=str2 %></h3>
</body>
</html>