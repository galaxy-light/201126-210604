<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page isErrorPage=true %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
   <h2>요청하신 페이지에서 문제가 발생했습니다</h2><br>
   <h2>서비스 사용에 불편을 끼쳐드려 대단히 죄송합니다</h2><br>
   <h2>빠른 시간 내에 문제를 처리하겠습니다</h2><br>
   
   <h1>예외타입: <%=exception.getClass().getName() %></h1><br>
   <h2>에러메세지 : <%=exception.getMessage() %></h2>
</body>
</html>