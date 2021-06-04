<%@page import="com.mk.web.dto.Product"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<jsp:useBean id="productDAO" class="com.mk.web.dao.ProductRepo" scope="session"/>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<title>Insert title here</title>
</head>
<body>
	<jsp:include page="menu.jsp"></jsp:include>
	<div class = "jumbotron">
		<div class="container">
			<h1 class = "display-3">제품 리스트</h1>
		</div>
	</div>
	<%ArrayList<Product> list = productDAO.getAllProducts(); %>
	<div class="container">
		<div class="row" align="center">
			<%
				for(int i =0; i<list.size();i++){
					Product product = list.get(i);
				
			%>
			<div class="col-md-4">
				<h3><%=product.getPname() %></h3>
				<p><%=product.getDescription() %>
				<p><%=product.getUnitPrice() %>
				<p><a href="product.jsp?id=<%=product.getProductId() %>" 
				class="btn btn-secondary" role = "button">상세 정보 &raquo;</a>
			</div>
			<%} %>
		</div>
		<hr>
	</div>
	<jsp:include page="footer.jsp"></jsp:include>
</body>
</html>