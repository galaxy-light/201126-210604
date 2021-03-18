<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>값을 입력하는 폼</title>
</head>
<body>
	<h2>숫자 값을 입력하세요.</h2>
	
	<!-- get 방식은 text 정보가 노출되기 때문에 보안상 취약함 -->	
	<!-- <form method="get" action=ifTestPro.jsp> -->
	<!-- post 방식은 text 정보(변수)가 숨겨져 있음 -->
	<form method="post" action=http://localhost:8080/control0318/calc/ifTestPro.jsp> 
	<!-- action=calc/ifTestPro.jsp : 상대경로 -->
	<!-- action=/control0318/calc/ifTestPro.jsp : 절대경로(프로젝트 기준) -->
	<!-- action=http://localhost:8080/control0318/calc/ifTestPro.jsp : url 경로 -->
		<input type="text" name="number">
		<input type="submit" value="입력 완료">
	</form>
</body>
</html>