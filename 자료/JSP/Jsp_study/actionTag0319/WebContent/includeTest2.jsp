<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%
    request.setCharacterEncoding("utf-8");
    String name = "홍길동";
    String pageName = "includedTest2.jsp";
    
    %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1>includeTest2.jsp 페이지 입니다.</h1><br>
	
	<jsp:include page="<%=pageName %>">
		<jsp:param value="<%=name %>" name="name"/>
		<jsp:param value="<%=pageName %>" name="pageName"/>
	</jsp:include>
</body>
</html>