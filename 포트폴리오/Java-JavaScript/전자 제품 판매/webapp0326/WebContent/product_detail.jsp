<%@page import="java.util.Locale"%>
<%@page import="com.hh.web.dto.Product"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<jsp:useBean id="productDAO" class="com.hh.web.dao.ProductRepo" scope="session"/>  
<!-- 4번 라인 : 클래스에 객체를 생성한다는 뜻 --> 
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
<title>제품 상세 정보</title>
</head>
<body>
	<jsp:include page="./menu.jsp"/>
	<!-- ./menu.jsp와 menu.jsp는 동일 -->
   	<div class="jumbotron">
      <div class="container">
         <h1 class="display-3">제품 정보</h1>
      </div>
   	</div>
   	<%   	
   	String id = request.getParameter("id");
   	/* id : 일종의 변수 역할 */
    Product product = productDAO.getProductById(id);
   	/* 사용자가 선택한 제품 정보를 받기 위해서 id 사용 */
   	
   	/* 가격 표시 */
   	int price = product.getUnitPrice();
   	String strPrice = String.format(Locale.KOREAN, "￦%,d", price);
   	%>
   <div class="container">
      <div class="row">
         <div class="col-md-6">            
          	<h3><%=product.getPname() %></h3>
            <p><b>상품 코드 : </b><span class="badge badge-danger">
            <%=product.getProductId() %></span>
            <p><b>제조사</b> : <%=product.getManufacturer() %>
            <p><b>분류</b> : <%= product.getCategory() %>
            <p><b>재고 수량</b> : <%=product.getUnitInStock() %>
            <h4><%=product.getUnitPrice()%>원</h4>
            <p><a href="#" class="btn btn-info">상품 주문 &raquo;</a> 
            <a href="./products.jsp" class="btn btn-secondary">제품 목록 &raquo;</a>
         </div>
      </div>
	</div>
	<jsp:include page="./footer.jsp"/>
</body>
</html>