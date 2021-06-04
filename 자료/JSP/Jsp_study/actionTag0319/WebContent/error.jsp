<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%@ page isErrorPage="true" %>    
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h2>요청하신 페이지에서 문제가 발생했습니다.</h2>
	<h2>서비스 사용에 불편을 끼쳐드려서 대단히 죄송합니다.</h2>
	<h1>예외 타입: <%=exception.getClass().getName() %></h1>
	
	<h1>예외 타입 : <%=exception.getMessage() %></h1>
</body>
</html>