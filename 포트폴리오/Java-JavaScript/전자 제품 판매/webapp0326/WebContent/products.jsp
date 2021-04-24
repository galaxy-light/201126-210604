<%@page import="com.hh.web.dto.Product"%>
<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>   
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>     
<jsp:useBean id="productDAO" class="com.hh.web.dao.ProductRepo" scope="session" />
<!-- productDAO : 객체 생성을 참조하는 변수  -->
<!-- /이 닫는 태그 역할 -->
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<title>제품 목록</title>
</head>
<body>	
	<jsp:include page="menu.jsp"/>
	<div class="jumbotron">
		<div class="contatiner">
			<h1 class="display-3">제품 리스트</h1>
		</div>
	</div>
	<%
	ArrayList<Product> list = productDAO.getAllProduct();
	%>
	<div class="container">
		<div class="row" align="center">
			<%
			for (int i=0; i<list.size(); i++) {
				 Product product = list.get(i);
			%>
			<c:set var="price" value="<%=product.getUnitPrice() %>"></c:set>
			<div class="col-md-4">
				<h3><%=product.getPname() %></h3>
				<p><%=product.getDescription() %>
				<p><fmt:setLocale value="ko_KR"/>
					<fmt:formatNumber type="currency" value="${price}"/>원
				<p><%=product.getUnitPrice() %>원
				<p><a href="product_detail.jsp?id=<%=product.getProductId() %>" class="btn btn-secondary" role="button">상세 정보 &raquo;</a>
				<!-- a href="product.jsp?id=product.getProductId() : id 값을 넘김 -->
				<!-- 특정한 값을 넘길 때 ? 사용 -->
			</div>
			<% } %>
		</div>
	</div>
	<jsp:include page="footer.jsp"/>
</body>
</html>