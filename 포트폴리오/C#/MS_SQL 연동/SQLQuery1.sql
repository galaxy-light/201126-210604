/****** SSMS의 SelectTopNRows 명령 스크립트 ******/
SELECT TOP (1000) [temp_id]
      ,[temp_name]
  FROM [Test_01].[dbo].[Table_1]

INSERT INTO Table_1 (temp_id, temp_name) VALUES (4, '홍길동')
INSERT INTO Table_1 (temp_id, temp_name) VALUES (5, '일지매')
INSERT INTO Table_1 (temp_id, temp_name) VALUES (6, '임꺽정')