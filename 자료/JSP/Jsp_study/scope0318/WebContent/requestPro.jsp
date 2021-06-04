<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
    <%
    
    request.setCharacterEncoding("UTF-8");
    
    int  num = Integer.parseInt(request.getParameter("num"));
    String name = request.getParameter("name");
    int  grade = Integer.parseInt(request.getParameter("grade"));
    String subject = request.getParameter("subject");
    
    
    out.println("<h2> 학번 : " + num + "입니다. </h2>");
    out.println("<h2> 이름 : " + name + "입니다. </h2>");
    out.println("<h2> 학년 : " + grade + "학년 입니다. </h2>");
    out.println("<h2> 과목 : " + subject + "입니다. </h2>");
    %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	
</body>
</html>