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
	<h1>포워딩 되어진 페이지: forwardToTest.jsp</h1><br>
	<h2>ID:<%=id %></h2><br>
	<h2>취미:<%=hobby %></h2>
</body>
</html>