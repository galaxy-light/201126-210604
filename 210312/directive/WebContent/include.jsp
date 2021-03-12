<%@ page language="java" contentType="text/html; charset=utf-8"
	pageEncoding="utf-8"%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>Include 처리</title>
</head>
<body>
	<%@ include file="top.jsp"%>
	<h2>메인영역 : top, bottom 영역 불러오기</h2>
	<%@ include file="bottom.jsp" %>
</body>
</html>