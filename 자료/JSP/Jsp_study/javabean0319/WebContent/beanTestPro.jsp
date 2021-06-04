<%@page import="javabean0319.TestBean"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    <%
    request.setCharacterEncoding("utf-8");
    %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<jsp:useBean id="testBean" class="javabean0319.TestBean">
		<jsp:setProperty name="testBean" property="name"/>
	</jsp:useBean>
	
	<h2>
	입력된 이름 : <jsp:getProperty property="name" name="testBean"/>
	</h2>
</body>
</html>