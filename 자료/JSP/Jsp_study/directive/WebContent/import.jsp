<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import = "java.sql.Timestamp" %>
<%@ page import="java.util.Date" %>
<%@ page import="java.text.SimpleDateFormat" %>
<%@ page info="Copyright by 홍길동" %>
<%@ page session=true %>

<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Directive import 속성</title>
</head>
<body>
	<h2>page디렉티브 - import 속성</h2>

	<%
		Timestamp now = new Timestamp(System.currentTimeMillis());
		SimpleDateFormat format =new SimpleDateFormat("yyyy-MM-dd");
		String strDate = format.format(now);
		
		Date nowTime = new Date();
		SimpleDateFormat date = new SimpleDateFormat("yyyy년MM월dd일 a hh시 mm분 ss초");
	%>
	
	<h1>오늘은 <%=strDate %> 입니다.</h1>
	<h1>현재 날씨와 시간은 <%= date.format(nowTime) %></h1>
	
	<h2>저작자: <%=getServletInfo() %></h2>
</body>
</html>