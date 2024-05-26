#����������� ������������
##����
###����

��� ������� �� ������ ���������, � ���� �����, ��������� ����� ����. ������ ���������� ����, ������� �� ������ ��� �������������, ���������.
��������� - �������, ����������� ��������� ����� � ����������� �.txt�. (����� ���� ���������, � ���������� - ���������.)
������ ����������� � ���������� ��� ����������� ������ ���, ��� ��� ������� �� ������ ����������� ���������� �������� ������ ���� ��� �� �����, 
���� �� ������ ��������� ���� (���� ���� ��� �� ��� �������� ������), � ��� ������� �� ���������� ��� ������ ��� ����� ����������� ���������� ���� � ������� ���� 
��� ���������� �����.
������ "�����" ��������� ���� ���������.



###������
� ���� ������� ������������� ������� ��� ��������� ������.

���������� ������� ��������� ��������.
� ���� ���� ���-�� ������� �� ������, ���������� � ����� ������, �� ����� ��������������� ������� ����������, ����� ��������� ���� ������� ������, 
������� ����� ������� � ����������� � ����� ������.
������� ������������ ��������� ���������� ������� ������.
������� �� ������ ����������, �� ���������� ��������� � ������ ������ ������� ������.
��������� ������ ������ ���������� ������� ������.
"���������" ��������� ��������� ��������� � ������.
"�������� ��" �������� ���� �����.


###����
��������� �������������� ����������

###�������
� ���� ���� ����� ������ ���������� � ���������.

###"����� �������" ������� ������ ����������� ������������.
"� ���������" ������� ������ ���������.


##������ ������������
�������� ������ ��� �������� ������� � ��������:
-������� ����
-������� ����
-��������� ����
-��������
-���������
-����������
-��������
-��������
-����
-����� �������
-� ���������

#2_________________________________________________________
 
![image](task.PNG)
##1)���������� ������ ����������� ����������. ������� ���������� ������������ �����������. �������������� �������� � ��������� ����������� ���������� �������. �������������� ��������� ��������� ������� (������� �������� ������������ � ������������� ������). ����������� ����������� ����������, ����������� �������� � ������ �������, ���� ������� ������� ������������� (�������� ������). �������� ������ � ����� ������������� ��������� ���������� ���������. ������, ��� ����� ��� ������� ����� �������� �� ��������� �����. 


##2)��������� �������


![image](lex_diagram.PNG)
 

3)������ ������ ���������


![image](example_lexer.PNG)

#3-------------------------------------------------------------
#������������ ������ 3

##���������� G[ ]: 
G:

VT = { �func� �return� �int� �a���z� �A���Z� �0���9� �(� � � �,� �)� �{� �_� �+� �-� �*� �/� �}� }

VN = {DEF, FUNCNAME, FUNCNAMEREM, ARGNAME, ARGNAMEREM, TYPEARG, TYPEFUNC, FUNCOPEN, RETURN, ARG1NAME, ARG1NAMEREM, ARG2NAME, ARG2NAMEREM, END, digit, letter}

P = {

DEF -> 'func' FUNCNAME

FUNCNAME -> (letter | '_') FUNCNAMEREM

FUNCNAMEREM -> (letter | digit | '_') FUNCNAMEREM | '(' ARGNAME

ARGNAME -> (letter | '_') ARGNAMEREM

ARGNAMEREM -> (letter | digit | '_') ARGNAMEREM | ' , ' ARGNAME | TYPEARG

TYPEARG -> 'int' ') ' TYPEFUNC

TYPEFUNC -> 'int' FUNCOPEN

FUNCOPEN -> '{' RETURN

RETURN -> 'return' ARG1NAME

ARGNAME -> (letter | '_') ARGNAMEREM 

ARGNAMEREM -> (letter|digit|'_') ARGNAMEREM | (+ | - | * | /) ARGNAME | END

END -> '}'}


##������� ������ �����:
 

func add(x, y int)int

{

	return x+y

}


func mul(x, y int)int{


	return x*y

}


##3)�������� �������
![image](parser_graph.PNG)

##���� ������: ����� � �������


![image](lr3_right.PNG)


![image](lr3_wrong.PNG)



#4-------------------------------------------------------------
#������������ ������ 4

## ������������ ������ �4: ������������� ������ (����� �������)

**����**: ������������� ������ (����� �������).

**���� ������:** ����������� �������� ������������� �������������� ������ � ��������� �� ����������� ���������� �������.

### ����� �������

��������������� �������������� ���������� �������� �� ���� ���������� ����������. ��� ���������� �������, ������� �� ������������� ���������� ������������ ������ �������� ������������� � �����������������
�������� ���������� ������� �� ������� ������� �� ��� ���, ���� ��������� ������ �� �������� ����� �� ���������� � ������ ������ �������.

���� �������� ��� ���� ��� ���������� � ������������ ������ �3. � ������� ������ ��������� �� �������������� � ����� ������, ���������� ���������� �� ����������� ���������.


#4-------------------------------------------------------------
#������������ ������ 4


**����:** ��������� ��������� � ����������, �������� ���������� ����� ������������� ���������. 

**���� ������:** ��������� ����������, ������������� � ������ ������������ �����, ������ ������������ ���������� ����� ������������� ���������. ��������� ����������, ��������������� � ������ �������� ������, ����������� �� ���������� G[<��>]. ����������� ������ ��� ����������� ����������.

### �������� �������


1. **���� �1.** 
   
   ![image](lr5_1.PNG)


2. **���� �2.** ��������� ����������� ������.

   ![image](lr5_2.PNG)


3. **���� �3.** ��������� ����������� ����������.

   ![image](lr5_3.PNG)




#6-------------------------------------------------------------
#������������ ������ 6

����: ���������� ��������� ������ �������� � ������� ���������� ���������.

���� ������: ����������� �������� ������ � ������ ��������, ��������������� �������� ���������� ����������.

������� 1(1-24): ��������� ��, ����������� ���� ������������ ����.

��: \b\d{13}\b


![image](lr6_1.PNG)


������� 2(2-23): ��������� �� ��� ������ �����������

��: \b[A-Z�-�]{2,}\b


![image](lr6_2.PNG)


������� 3(3-24): ��������� ��, ����������� �����. ������: ��:��:�� �
24-������� ������� � ������������ ������� 0

��: (?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d


![image](lr6_3.PNG)


#7-------------------------------------------------------------
#������������ ������ 7


����: ���������� ������ ������������ ������ ��� ��������������� �������.

���� ������: ����������� ��� ���������� �������� ��������������� ������� �� ������ ������ ������������ ������.

��� ���������� G[<While>] ����������� � ����������� �������� ������� �� ������ ������ ������������ ������.

```
G[<While>]:

<While> ? do <Stmt>  while <Cond>;
<Cond> ? <LogExpr> {or <LogExpr>}
<LogExpr> ? <RelExpr> {and <RelExpr>}
<RelExpr> ? <Operand> [rel <Operand>]
<Operand> ? var | const
<Stmt> ? var as <ArithExpr>
<ArithExpr> ? <Operand> {ao <Operand>}
```

����������: while, do, end, and, or � �������� �����. � ��� rel ���������� �������� ��������� <,<=, >=, >, != � ==, � ��� ao �������������� �������� + � -, � ��� as �������� ������������ =, ��� var � �������� ���������� (������ �����), ��� const � �����. �������, �� ������� �� ���������� � ���� ��� ���������� �������� and � or ����������� � ���, ��� ��� �������� ����� ��������� ���������.

�� ������������� �������� ������ ���������� ��������� � ��.

### �������

```
do b = b - 20 while a < b; 
do abc = cde - 20 + 40 - 8 + efg while a < b and c != d or e == f or g <= h and i > j ;
 do b = a + % while a < b 
```

![image](lr7.PNG)


