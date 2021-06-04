<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%
	int num1 = 100;
	int num2 = 200;
	int result = num1+num2;
	String name = "홍길동";
%>    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<div><% out.print(result); %></div>
	<div><% out.println(num1 + num2);%></div>
	<div><h1>연산 결과:<%=result %></h1></div>
	<div><h1>이름:<%=name %></h1></div>
</body>
</html>