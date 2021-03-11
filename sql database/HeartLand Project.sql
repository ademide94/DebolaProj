
CREATE DATABASE heartLand_project
Drop table Admin_Login,Branch,Customer,Loan,Employee,SeniorManagement,Messanger,Payment
truncate table Admin_Login,Branch,Customer,Loan,Employee,SeniorManagement,Messanger,Payment,Administarator
CREATE TABLE Admin_Login
(
    UserName VARCHAR(50),
	Pass VARCHAR(50),	
)

insert into Admin_Login 
values('Admin','12345');
SELECT * FROM Admin_Login


CREATE TABLE Branch
(
      
      BranchName   VARCHAR(50) NOT NULL UNIQUE,
	  Branchcode     INT IDENTITY ( 22001, 1 ) UNIQUE,
	  _Address       VARCHAR(50),
	  Phone_no       VARCHAR(50) NOT NULL,
	  _state  VARCHAR(50) NOT NULL,
      City   VARCHAR(50) NOT NULL,
	  Zip_code       VARCHAR(50),
)
SELECT * FROM Branch



CREATE TABLE Customer
(
     Picture image,
     CustomerID   INT IDENTITY (21001, 1 ) UNIQUE,
     Name         VARCHAR(50) NOT NULL UNIQUE,
	 Date_of_Bath     VARCHAR(50) NOT NULL,
	 Marital_status    VARCHAR(50) NOT NULL,
     _Address    VARCHAR(50) NOT NULL,
	 City         VARCHAR(50) NOT NULL,     
     _State     VARCHAR(50) NOT NULL,
	 Contact      VARCHAR(50) NOT NULL,
     Zip_code          VARCHAR(50) NOT NULL,
  )
  SELECT * FROM Customer


  CREATE TABLE Loan
(
      Loan_ref_no      INT IDENTITY (32001,1 ) UNIQUE,
      Name     VARCHAR(50) NOT NULL ,
      LoanType     VARCHAR(100) NOT NULL,
	  _Address     VARCHAR(100) NOT NULL,
	  Application_date  VARCHAR(100) NOT NULL,
	  Email_address  VARCHAR(100) NOT NULL,
	  Guarantee_Provided  VARCHAR(100) NOT NULL,
      Annual_income       VARCHAR(50) NOT NULL,
	  Amount_of_Loan       VARCHAR(50)NOT NULL,
	  Loan_program_code   VARCHAR(50) NOT NULL UNIQUE,

)
 SELECT * FROM Loan




 CREATE TABLE Employee
(
     Picture image,
     Emp_ID   INT IDENTITY ( 64001,1) UNIQUE,
     Name         VARCHAR(50) NOT NULL UNIQUE,
	 Date_of_birth  VARCHAR(50) NOT NULL,
	 Date_of_joint  VARCHAR(50) NOT NULL,
     _Address       VARCHAR(50) NOT NULL,
     City         VARCHAR(50) NOT NULL,
     Emp_State     VARCHAR(50) NOT NULL,
     Designation       VARCHAR(50) NOT NULL,
     Code      VARCHAR(50) NOT NULL,
	 Username     VARCHAR(50) NOT NULL,
	 _Password     VARCHAR(50) NOT NULL,
	 Email      VARCHAR(50) NOT NULL,
	 Phone_no     VARCHAR(50) NOT NULL,
  )
  SELECT * FROM Employee


  CREATE TABLE SeniorManagement
(
     Picture image,
     ID   INT IDENTITY ( 74001,1) UNIQUE,
     First_Name          VARCHAR(50) NOT NULL UNIQUE,
	 Last_Name          VARCHAR(50) NOT NULL UNIQUE,
	 Date_of_joint  VARCHAR(50) NOT NULL,
     _Address       VARCHAR(50) NOT NULL,
     City          VARCHAR(50) NOT NULL,
     _State      VARCHAR(50) NOT NULL,
     Designation           VARCHAR(50) NOT NULL,
     Code      VARCHAR(50) NOT NULL,
	 Username      VARCHAR(50) NOT NULL,
	 _Password      VARCHAR(50) NOT NULL,
	 Email      VARCHAR(50) NOT NULL,
	 Phone_no      VARCHAR(50) NOT NULL,
  )
  SELECT * FROM SeniorManagement

  CREATE TABLE Messanger
(
     Message_To     VARCHAR(50) NOT NULL,
     Message_From        VARCHAR(50) NOT NULL,
     _Message            VARCHAR(500) NOT NULL,
)
 SELECT * FROM Messanger

   CREATE TABLE Payment
(
     Ref_No   INT IDENTITY ( 54001,1) UNIQUE,
     Check_Number      VARCHAR(50) NOT NULL,
     Check_Date            VARCHAR(300) NOT NULL,
	 Amount  VARCHAR(50)NOT NULL,
)
 SELECT * FROM Payment

   CREATE TABLE Administarator
(
     Picture image,
     ID   INT IDENTITY ( 74001,1) UNIQUE,
     First_Name          VARCHAR(50) NOT NULL UNIQUE,
	 Last_Name          VARCHAR(50) NOT NULL UNIQUE,
	 Date_of_joint  VARCHAR(50) NOT NULL,
     _Address       VARCHAR(50) NOT NULL,
     City          VARCHAR(50) NOT NULL,
     _State      VARCHAR(50) NOT NULL,
     Designation           VARCHAR(50) NOT NULL,
     Code      VARCHAR(50) NOT NULL,
	 Username      VARCHAR(50) NOT NULL,
	 _Password      VARCHAR(50) NOT NULL,
	 Email      VARCHAR(50) NOT NULL,
	 Phone_no      VARCHAR(50) NOT NULL,
  )
  Select * from Administarator




  CREATE TABLE Senior_Login
(
    UserName VARCHAR(50),
	Pass VARCHAR(50),	
)
  Select * from Senior_Login

CREATE TABLE Employee_Login
(
    UserName VARCHAR(50),
	Pass VARCHAR(50),	
)
  Select * from Employee_Login







