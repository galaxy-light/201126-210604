<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
session.setAttribute("ID", "noone");
session.setAttribute("NAME", "아무개");
%>    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1>session 정보 저장</h1>
	<%
	String id = (String)session.getAttribute("ID");
	String name = (String)session.getAttribute("NAME");
	%>
	<br>
	아이디 : <%=id %>
	이름 : <%=name %>
</body>
</html>