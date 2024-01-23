%{
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int yylex(void);
void yyerror(const char *s){
    printf( "syntax error\n");
	exit(1);
}

extern FILE *yyin;
%}

%union {
    int intval;
}

%token <intval> NUM
%token COLON INT PLUS MINUS MULT DIV IF ELSE ELSEIF WHILE
%token GREATER_THAN LESS_THAN EQUAL_EQUAL NOT_EQUAL GREATER_EQUAL LESS_EQUAL PRINT LPAREN RPAREN EQUAL

%%

program : statements
        ;

statements : statement
           | statements statement
           ;

statement :  if_stmnt 
        |   comp_stmts 
        |   art_stmts
        |   while_stmt
        |   print_stmt
        |   assigment_stmt
        |   exp_stmt 
        ;

assigment_stmt : IDENTIFIER EQUAL exp_stmt COLON ;
exp_stmt:   INT
        |   ID
        |   art_stmts
        ;

if_stmnt: IF LPAREN comp_stmts RPAREN COLON
        | IF LPAREN comp_stmts RPAREN COLON statements ELSEIF LPAREN comp_stmts LPAREN COLON
        | IF LPAREN comp_stmts RPAREN COLON statements ELSE COLON
        ;
comp_stmts: ID GREATER_THAN ID COLON
          | ID LESS_THAN ID COLON
          | ID EQUAL_EQUAL ID COLON
          | ID NOT_EQUAL ID COLON
          | ID GREATER_EQUAL ID COLON
          | ID LESS_EQUAL ID COLON

art_stmts:  ID PLUS ID COLON
          | ID MINUS ID COLON
          | ID MULT ID COLON
          | ID DIV ID COLON
          | ID PLUS INT COLON
          | ID MINUS INT COLON
          | ID MULT INT COLON
          | ID DIV INT COLON
            ;
while_stmt: WHILE LPAREN comp_stmts RPAREN statements
print_stmt: PRINT LPAREN ID RPAREN COLON
            |PRINT LPAREN statements RPAREN COLON
            ;

%%


void execute_print(const char *str) {
    printf("%s\n", str);
}

int main(int argc, char *argv[]) {

    yyparse();
    printf("OK!\n");

    return 0;
}
