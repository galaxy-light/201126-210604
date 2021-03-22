<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    <%
    request.setCharacterEncoding("utf-8");
    String id="gh";
    String hobby = "운동하기";
    %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
   <jsp:forward page="forwardToTest2.jsp">
   <jsp:param value="<%=id %>" name="id"/>
   <jsp:param value="<%=hobby %>" name="hobby"/>
   </jsp:forward>
</body>
</html>                                  