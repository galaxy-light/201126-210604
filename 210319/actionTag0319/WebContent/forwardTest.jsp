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
   <h1>포워딩하는 페이지: 화면에 표시되지않음</h1>
   <!-- forwardToTest.jsp 페이지로 이동 -->
   <jsp:forward page="forwardToTest.jsp"></jsp:forward>
</body>
</html>