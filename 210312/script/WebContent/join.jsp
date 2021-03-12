<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>회원가입 폼</title>
</head>
<style>
.table1{
	width:600px;
	border:1px solid #cccccc;	
	border-collapse:collapse; /* 여백제거 */
}
.td1{
	padding:5px;
	border:1px solid #cccccc;
}
.text_box1{
	width:150px;
	font-size:12px;
	color:#a7a7a7;
}
</style>
<body>
	<p id=pp1>Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis ratione corporis debitis? Quod consectetur quisquam tenetur aliquid, sunt quo maxime sit culpa explicabo aperiam, officia voluptates necessitatibus quaerat animi. Doloribus.</p>
    <p id=pp2>Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis ratione corporis debitis? Quod consectetur quisquam tenetur aliquid, sunt quo maxime sit culpa explicabo aperiam, officia voluptates necessitatibus quaerat animi. Doloribus.</p>
    <button id="pbtn1">javascript 버튼</button>
    <button id="pbtn2">jquery 버튼</button>
</body>
</html>
<!-- javascript -->
<script>
    document.getElementById("pbtn1").onclick = function () {
        // alert("버튼 누름");        
        if (document.getElementById("pp1").style.display == "none")
            document.getElementById("pp1").style.display="block";
        else
            document.getElementById("pp1").style.display = "none";   
        // alert(a);
    }
</script>
<!-- jquery -->
<script>
    $("#pbtn2").click(function () {
        $("#pp1").toggle(2500, function () { // 2500 : 2.5초
            $("#pp2").toggle(2500, function (){
            alert("끝났음")}); 
            }
        );
    })
</script>
</body>
</html>