<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    <%
    String name = request.getParameter("name");
    String pageName = request.getParameter("pageName");
    %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
   <h2>파라미터 값을 전달받아 실행함</h2>
   <h2>포함되는 페이지: <%=pageName %></h2><br>
   <h2><%=name %>님이 입장하셨습니다</h2>
</body>
</html>