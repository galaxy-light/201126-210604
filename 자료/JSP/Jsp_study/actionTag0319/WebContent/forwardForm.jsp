<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1>forward action tag</h1>

	<form method ="post" action = "forwardTest.jsp">
	아이디 <input type="text" name = "id"> <br>
	취미 
	<select name="hobby">
		<option value="wow">wow</option>
		<option value="만화">만화보기</option>
		<option value="게임하기">게임하기</option>
		
	</select>
	<input type="submit" value="입력완료">
	</form>
	
</body>
</html>