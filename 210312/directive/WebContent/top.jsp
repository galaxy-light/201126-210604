<%@ page language="java" contentType="text/html; charset=utf-8"
    pageEncoding="utf-8"%>
<%@ page import="java.sql.Timestamp" %>    
    
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>TOP</title>
</head>
<body>
	<%
	Timestamp now = new Timestamp(System.currentTimeMillis());	
	%>
	<h1>TOP 파일입니다.</h1>
	<h2><%= now.toString() %></h2>
</body>
</html>