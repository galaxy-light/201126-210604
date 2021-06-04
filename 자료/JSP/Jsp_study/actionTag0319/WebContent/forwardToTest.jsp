<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    <%
    request.setCharacterEncoding("utf-8");
    String id = request.getParameter("id");
    String hobby = request.getParameter("hobby");
    %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h2>forwardTest.jsp 에서 포워딩 되었음</h2><br>
	<h1>ID:<%=id %></h1><br>
	<h1>취미:<%=hobby%></h1>
</body>
</html>