%{
#include <stdio.h>
#include <string.h>
#include "y.tab.h"
extern FILE *yyin;
extern int linenumber;
extern int tabnum;
FILE *output;
%}
%union
{
char *string;
}
%token <string> FOR IF WHILE ELSE ELIF STRING_LITERAL IDENTIFIER INTEGER COMMENT EQUAL_SYMBOL COLON SEMICOLON NOT_EQUAL OPEN_BARACKETS CLOSE_BARACKETS MINUS PLUS OPEN_PARANTHESIS CLOSE_PARANTHESIS DIVIDE LESSOREQUAL EQUAL NOTEQUAL LESSTHAN GREATERTHAN GREATEROREQUAL MULT ELIF FLOAT
%type <string> op
%type <string> parameters
%type <string> opsign
%type <string> statements
%type <string> statements2
%type <string> statement
%type <string> statement2
%type <string> write_output
%type <string> write_output2
%type <string> write_output3
%type <string> commentsection
%type <string> assignment_list
%type <string> assignment_list2
%type <string> assignment_list3
%type <string> if_statement
%type <string> if_statement2
%type <string> if_statement3
%type <string> while_statement
%type <string> while_statement2
%type <string> while_statement3
%type <string> comparison
%type <string> elif_statements
%type <string> elif_statements2
%type <string> elif_statements3
%%

program:
	statements 
	;

statements:
	statement statements 
	|
	statement 
	;

statements2:
	statement2 statements2  {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+1));strcpy(s,$1);strcat(s,$2);$$=s;} 
	|
	statement2 {$$=$1;} 
	;

statement2:
	predirective 
	|
	write_output2 {$$=$1;}
	|
	assignment_list2 {$$=$1;}
	|
	commentsection {$$=$1;}
	|
	if_statement2 {$$=$1;}
	|
	while_statement2 {$$=$1;}
	;

statement:
	predirective 
	|
	write_output {$$=$1;}
	|
	assignment_list {$$=$1;}
	|
	commentsection {$$=$1;}
	|
	if_statement {$$=$1;}
	|
	while_statement {$$=$1;}
	;

if_statement:
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS THEN statements2 {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+5+1+1+1+1+1+1+1+1));strcpy(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"}");strcat(s,"\n");$$=s;fprintf(output,"%s",$$);}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS THEN statements2 elif_statements ELSE statements2{char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+strlen($8)+strlen($9)+5+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"}");strcat(s,$7);strcat(s,$8);strcat(s,"{");strcat(s,"\n");strcat(s,$9);strcat(s,"}");strcat(s,"\n");$$=s;fprintf(output,"%s",$$);}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS THEN statements2 ELSE statements2 {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+strlen($8)+5+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"}");strcat(s,$7);strcat(s,"{");strcat(s,"\n");strcat(s,$8);strcat(s,"}");strcat(s,"\n");$$=s;fprintf(output,"%s",$$);}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS THEN statements2 elif_statements {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+5+1+1+1+1+1+1+1+1));strcpy(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"}");strcat(s,$7);strcat(s,"\n");$$=s;fprintf(output,"%s",$$);}
	;

if_statement2:
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS statements3 FI {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+5+1+1+1+1+1+1+1+1+1));strcpy(s,"\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t");strcat(s,"}");strcat(s,"\n");$$=s;}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS statements3 elif_statements2 ELSE statements3 {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+strlen($8)+strlen($9)+5+1+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,"\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t");strcat(s,"}");strcat(s,$7);strcat(s,$8);strcat(s,"{");strcat(s,"\n");strcat(s,$9);strcat(s,"}");strcat(s,"\n");$$=s;}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS statements3 ELSE statements3 {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+strlen($8)+5+1+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,"\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"}");strcat(s,$7);strcat(s,"{");strcat(s,"\n");strcat(s,$8);strcat(s,"\t");strcat(s,"}");strcat(s,"\n");$$=s;}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS statements3 elif_statements2 {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+5+1+1+1+1+1+1+1+1+1));strcpy(s,"\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t");strcat(s,"}");strcat(s,$7);strcat(s,"\n");$$=s;}
	;

if_statement3:
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS OPEN_BARACKETS statements3 CLOSE_BARACKETS {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+5+1+1+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,"\t\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t\t");strcat(s,"}");strcat(s,"\n");$$=s;}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS OPEN_BARACKETS statements3 CLOSE_BARACKETS elif_statements3 ELSE statements3 {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+strlen($8)+strlen($9)+5+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,"\t\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t\t");strcat(s,"}");strcat(s,$7);strcat(s,$8);strcat(s,"{");strcat(s,"\n");strcat(s,$9);strcat(s,"}");strcat(s,"\n");$$=s;}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS OPEN_BARACKETS statements3 CLOSE_BARACKETS ELSE statements3 {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+strlen($8)+5+1+1+1+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,"\t\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"}");strcat(s,$7);strcat(s,"{");strcat(s,"\n");strcat(s,$8);strcat(s,"\t\t");strcat(s,"}");strcat(s,"\n");$$=s;}
	|
	IF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS OPEN_BARACKETS statements3 CLOSE_BARACKETS elif_statements3 {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+strlen($7)+5+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,"\t\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t\t");strcat(s,"}");strcat(s,$7);strcat(s,"\n");$$=s;}
	;

elif_statements3:
	ELIF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS statements3 {char* s=malloc(sizeof(char)*(strlen($3)+strlen($6)+5+1+1+1+1+1+1+1+1));strcpy(s,"elsif");strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t\t");strcat(s,"}");$$=s;}
	;

elif_statements2:
	ELIF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS statements3 {char* s=malloc(sizeof(char)*(strlen($3)+strlen($6)+5+1+1+1+1+1+1));strcpy(s,"elsif");strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t");strcat(s,"}");$$=s;}
	;

elif_statements:
	ELIF OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS statements2 {char* s=malloc(sizeof(char)*(strlen($3)+strlen($6)+5+1+1+1+1+1+1));strcpy(s,"elsif");strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"}");$$=s;}
	;

while_statement3:
	WHILE OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS OPEN_BARACKETS statements3 CLOSE_BARACKETS {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+5+1+1+1+1+1+1+1+1+1+1+1+1+1));strcpy(s,"\t\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"\n");strcat(s,"\t\t");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t\t");strcat(s,"}");strcat(s,"\n");$$=s;}
	;

while_statement2:
	WHILE OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS OPEN_BARACKETS statements3 CLOSE_BARACKETS {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+5+1+1+1+1+1+1+1+1+1));strcpy(s,"\t");strcat(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"\n");strcat(s,"\t");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"\t");strcat(s,"}");strcat(s,"\n");$$=s;}
	;

while_statement:
	WHILE OPEN_PARANTHESIS comparison CLOSE_PARANTHESIS OPEN_BARACKETS statements2 CLOSE_BARACKETS {char* s=malloc(sizeof(char)*(strlen($1)+strlen($3)+strlen($6)+5+1+1+1+1+1+1+1+1));strcpy(s,$1);strcat(s,"(");strcat(s,$3);strcat(s,")");strcat(s,"\n");strcat(s,"{");strcat(s,"\n");strcat(s,$6);strcat(s,"}");strcat(s,"\n");$$=s;fprintf(output,"%s",$$);}
	;

comparison:
	IDENTIFIER LESSOREQUAL INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," <= ");strcat(s,$4);$$=s;}
	|
	IDENTIFIER GREATERTHAN INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," > ");strcat(s,$4);$$=s;}
	|
	IDENTIFIER GREATEROREQUAL INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," >= ");strcat(s,$4);$$=s;}
	|
	IDENTIFIER EQUAL INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," == ");strcat(s,$4);$$=s;}
	|
	IDENTIFIER NOTEQUAL INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," != ");strcat(s,$4);$$=s;}
	|
	IDENTIFIER LESSTHAN INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," < ");strcat(s,$4);$$=s;}
	|
	IDENTIFIER LESSOREQUAL IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+strlen($5)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," <= ");strcat(s,$4);strcat(s,$5);$$=s;}
	|
	IDENTIFIER GREATERTHAN IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+strlen($5)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," > ");strcat(s,$4);strcat(s,$5);$$=s;}
	|
	IDENTIFIER GREATEROREQUAL IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+strlen($5)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," >= ");strcat(s,$4);strcat(s,$5);$$=s;}
	|
	IDENTIFIER EQUAL IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+strlen($5)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," == ");strcat(s,$4);strcat(s,$5);$$=s;}
	|
	IDENTIFIER NOTEQUAL IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+strlen($5)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," != ");strcat(s,$4);strcat(s,$5);$$=s;}
	|
	IDENTIFIER LESSTHAN IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($4)+strlen($5)+1+1+1+1));strcpy(s,$1);strcat(s,$2);strcat(s," < ");strcat(s,$4);strcat(s,$5);$$=s;}
	;
	
commentsection:
	COMMENT {$$=$1;fprintf(output,"%s\n",$$);}
	;

assignment_list3:
	IDENTIFIER EQUAL_SYMBOL INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+5+1+1+1+1+1+1));strcpy(s,"\t\t");strcat(s,"$");strcat(s,$1);strcat(s,$2);strcat(s,$3);strcat(s,";");strcat(s,"\n");$$=s;}  //Burada memoryde malloc ile belli bir yer açtım ne kadar yer açacağımı lexemelerin boyutuna göre ve kullanılan sembollerin boyutuna göre ikisinin toplamı kadar olacak şekilde belirledim daha sonra bir karakter pointerı yardımıya burayı tutup içerisine ilk elemanı strcpy fonksiyonuyla attım kopyala yapıştır yapmış oldum strcpy nin içindekini daha sonra ardan gelen ifadeleri ona strcat fonksiyonu ile concatinate ettim yanı ardına ekledim birleştirdim böylelikle birden fazla string olan ifadeyi tek bir string olarak topladım daha sonra da bu stringi pointer yardımıyla eşitleyerek $$ ile hangi statete isem ona yolladım oradan da yukarıya doğru yollamış oldum.
	|
	IDENTIFIER EQUAL_SYMBOL VARIABLE_PREIDENTIFIER OPEN_BARACKETS op CLOSE_BARACKETS {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+strlen($6)+5+1+1+1+1));strcpy(s,"\t\t");strcat(s,$3);strcat(s,$1);strcat(s,$2);strcat(s,$6);strcat(s,";");strcat(s,"\n");$$=s;}  //Burada memoryde malloc ile belli bir yer açtım ne kadar yer açacağımı lexemelerin boyutuna göre ve kullanılan sembollerin boyutuna göre ikisinin toplamı kadar olacak şekilde belirledim daha sonra bir karakter pointerı yardımıya burayı tutup içerisine ilk elemanı strcpy fonksiyonuyla attım kopyala yapıştır yapmış oldum strcpy nin içindekini daha sonra ardan gelen ifadeleri ona strcat fonksiyonu ile concatinate ettim yanı ardına ekledim birleştirdim böylelikle birden fazla string olan ifadeyi tek bir string olarak topladım daha sonra da bu stringi pointer yardımıyla eşitleyerek $$ ile hangi statete isem ona yolladım oradan da yukarıya doğru yollamış oldum.		
	;

assignment_list2:
	IDENTIFIER EQUAL_SYMBOL INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+5+1+1+1+1));strcpy(s,"\t");strcat(s,"$");strcat(s,$1);strcat(s,$2);strcat(s,$3);strcat(s,";");strcat(s,"\n");$$=s;}  //Burada memoryde malloc ile belli bir yer açtım ne kadar yer açacağımı lexemelerin boyutuna göre ve kullanılan sembollerin boyutuna göre ikisinin toplamı kadar olacak şekilde belirledim daha sonra bir karakter pointerı yardımıya burayı tutup içerisine ilk elemanı strcpy fonksiyonuyla attım kopyala yapıştır yapmış oldum strcpy nin içindekini daha sonra ardan gelen ifadeleri ona strcat fonksiyonu ile concatinate ettim yanı ardına ekledim birleştirdim böylelikle birden fazla string olan ifadeyi tek bir string olarak topladım daha sonra da bu stringi pointer yardımıyla eşitleyerek $$ ile hangi statete isem ona yolladım oradan da yukarıya doğru yollamış oldum.
	|
	IDENTIFIER EQUAL_SYMBOL OPEN_BARACKETS op CLOSE_BARACKETS {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+strlen($6)+5+1+1));strcpy(s,"\t");strcat(s,$3);strcat(s,$1);strcat(s,$2);strcat(s,$6);strcat(s,";");strcat(s,"\n");$$=s;} //Burada memoryde malloc ile belli bir yer açtım ne kadar yer açacağımı lexemelerin boyutuna göre ve kullanılan sembollerin boyutuna göre ikisinin toplamı kadar olacak şekilde belirledim daha sonra bir karakter pointerı yardımıya burayı tutup içerisine ilk elemanı strcpy fonksiyonuyla attım kopyala yapıştır yapmış oldum strcpy nin içindekini daha sonra ardan gelen ifadeleri ona strcat fonksiyonu ile concatinate ettim yanı ardına ekledim birleştirdim böylelikle birden fazla string olan ifadeyi tek bir string olarak topladım daha sonra da bu stringi pointer yardımıyla eşitleyerek $$ ile hangi statete isem ona yolladım oradan da yukarıya doğru yollamış oldum.		
	;

assignment_list:
	IDENTIFIER EQUAL_SYMBOL INTEGER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+5+1+1+1+1));strcpy(s,"$");strcat(s,$1);strcat(s,$2);strcat(s,$3);strcat(s,";");strcat(s,"\n");$$=s;fprintf(output,"%s",$$);}
	IDENTIFIER EQUAL_SYMBOL OPEN_BARACKETS op CLOSE_BARACKETS {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+strlen($6)+5+1+1));strcpy(s,$3);strcat(s,$1);strcat(s,$2);strcat(s,$6);strcat(s,";");strcat(s,"\n");$$=s;fprintf(output,"%s",$$);}	
	;

write_output:
	VARIABLE_PREIDENTIFIER IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($2)+strlen($3)+5+1+5+1+1+1+1+7+1+1+1));strcpy(s,"print ");strcat(s,$2);strcat(s,$3);strcat(s," . \"\\n\";\n");$$=s;fprintf(output,"%s",$$);}
	|
	VARIABLE_PREIDENTIFIER OPEN_PARANTHESIS OPEN_PARANTHESIS op CLOSE_PARANTHESIS CLOSE_PARANTHESIS {char* s=malloc(sizeof(char)*(strlen($5)+5+1+5+1+1+1+1+7+1+1+1));strcpy(s,"print ");strcat(s,$5);strcat(s," . \"\\n\";\n");$$=s;fprintf(output,"%s",$$);}
	;

write_output2:
	VARIABLE_PREIDENTIFIER IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($2)+strlen($3)+5+1+5+1+1+1+1+7+1+1+1));strcpy(s,"\tprint ");strcat(s,$2);strcat(s,$3);strcat(s," . \"\\n\";\n");$$=s;}
	|
	VARIABLE_PREIDENTIFIER OPEN_PARANTHESIS OPEN_PARANTHESIS op CLOSE_PARANTHESIS CLOSE_PARANTHESIS {char* s=malloc(sizeof(char)*(strlen($5)+5+1+5+1+1+1+1+7+1+1+1));strcpy(s,"\tprint ");strcat(s,$5);strcat(s," . \"\\n\";\n");$$=s;}
	;

write_output3:
	VARIABLE_PREIDENTIFIER IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($2)+strlen($3)+5+1+5+1+1+1+1+7+1+1+1));strcpy(s,"\t\tprint ");strcat(s,$2);strcat(s,$3);strcat(s," . \"\\n\";\n");$$=s;}
	|
	VARIABLE_PREIDENTIFIER OPEN_PARANTHESIS OPEN_PARANTHESIS op CLOSE_PARANTHESIS CLOSE_PARANTHESIS {char* s=malloc(sizeof(char)*(strlen($5)+5+1+5+1+1+1+1+7+1+1+1));strcpy(s,"\t\tprint ");strcat(s,$5);strcat(s," . \"\\n\";\n");$$=s;}
	;

op:
	parameter opsign parameter {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+1));strcpy(s,$1);strcat(s,$2);strcat(s,$3);$$=s;}
	|
	OPEN_PARANTHESIS op CLOSE_PARANTHESIS {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+1));strcpy(s,$1);strcat(s,$2);strcat(s,$3);$$=s;}
	|
	op opsign parameter {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+1));strcpy(s,$1);strcat(s,$2);strcat(s,$3);$$=s;}
	|
	parameters opsign op {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+1));strcpy(s,$1);strcat(s,$2);strcat(s,$3);$$=s;}
	| 	
	op opsign op {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+1));strcpy(s,$1);strcat(s,$2);strcat(s,$3);$$=s;}
	|
	OPEN_PARANTHESIS IDENTIFIER opsign parameters CLOSE_PARANTHESIS opsign IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+strlen($3)+strlen($4)+strlen($5)+strlen($6)+strlen($7)+1));strcpy(s,$1);strcat(s,"$");strcat(s,$2);strcat(s,$3);strcat(s,$4);strcat(s,$5);strcat(s,$6);strcat(s,"$");strcat(s,$7);$$=s;}
	;

opsign:
	MULT {$$=$1;}
	|
	PLUS {$$=$1;}
	|
	DIVIDE {$$=$1;}
	|
	MINUS {$$=$1;}
	;

parameters_deneme:
	INTEGER {$$=$1;}
	|
	FLOAT {$$=$1;}
	|
	VARIABLE_PREIDENTIFIER IDENTIFIER {char* s=malloc(sizeof(char)*(strlen($1)+strlen($2)+1));strcpy(s,$1);strcat(s,$2);$$=s;}
	;

%%
void yyerror(char *s){
	fprintf(stderr,"Error at line: %d\nName of the Error: %s\n",linenumber,s);
}
int yywrap(){
	return 1;
}
int main(int argc, char *argv[])
{
    /* Call the lexer, then quit. */
    yyin=fopen(argv[1],"r");
    output=fopen(argv[2],"w");	
    yyparse();
    fclose(yyin);
    fclose(output);	
    return 0;
}