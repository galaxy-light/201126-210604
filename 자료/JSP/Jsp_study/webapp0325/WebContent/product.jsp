<%@page import="java.util.Locale"%>
<%@page import="com.mk.web.dto.Product"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <jsp:useBean id="productDAO" class="com.mk.web.dao.ProductRepo" scope="session"/>
<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<jsp:include page="./menu.jsp"></jsp:include>
	<div class="jumbotron">
		<div class = "container">
			<h1 class="display-3">제품정보</h1>
		</div>
	</div>
	<%
	String id = request.getParameter("id");
	Product product = productDAO.getProductById(id);
	int price = product.getUnitPrice();
	String strPrice = String.format(Locale.KOREAN, "￦%,d", price);
	%>
	
	<div class="container">
		<div class="row">
			<div class="col-md-6">
				<h3><%=product.getPname() %></h3>
				<p><%=product.getDescription() %>
				<p><b>상품코드:</b><span class="badge badge-danger">
				<%=product.getProductId() %></span>
				<p><b>제조사 :</b><span class="badge badge-secondary">
				<%=product.getManufacturer() %></span>
				
				<p><b>분류:</b><span class="badge badge-info">
				<%=product.getCategory() %></span>
				<p><b>제고수량:</b><span class="badge badge-dark">
				<%=product.getUnitInStock() %></span>
				<%-- <h3><%=product.getUnitPrice() %>원</h3> --%>
				<h3><%=strPrice %>원</h3>
				<p><a href="#" class ="btn btn-info">상품 주문 &raquo;</a>
					<a href="./products.jsp" class="btn btn-secondary">
					제품 목록&raquo;</a>
			</div>
		</div>
	</div>
	<jsp:include page="./footer.jsp"></jsp:include>
</body>
</html>