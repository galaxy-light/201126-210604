<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
//한글처리
request.setCharacterEncoding("UTF-8");

%>
<%
String name = request.getParameter("name");
String local = request.getParameter("local");
String tel = request.getParameter("tel");
String localNum = "";

if(local.equals("서울")){
	localNum = "02";
}
else if(local.equals("대구")){
	localNum = "053";
}
else if(local.equals("부산")){
	localNum = "051";
}


out.println("<b>" + name + "</b>님의 전화번호는"+localNum + "-" + tel + "입니다.");

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