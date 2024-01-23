%{
    #include "y.tab.h"
    #include <stdio.h>
    #include <string.h>
    int linenumber = 1;
    int tabnum = 0;
%}
%%

"basss"    {return print;}
"f"       {yylval.string = strdup(yytext);return FOR;}
"?"        {yylval.string = strdup(yytext);return IF;}
"w"     {yylval.string = strdup(yytext);return WHILE;}
"???"      {yylval.string = strdup(yytext);return ELSE;}
"??"   {yylval.string = strdup(yytext);return ELIF;}
"="         {yylval.string = strdup(yytext);return EQUAL_SYMBOL;}
":"         return COLON;
";"         {yylval.string = strdup(yytext);return SEMICOLON;}
"!="        {yylval.string = strdup(yytext);return NOT_EQUAL;}
"[ "        {yylval.string = strdup(yytext);return OPEN_BARACKETS;}
" ]"        {yylval.string = strdup(yytext);return CLOSE_BARACKETS;} 
"-"         {yylval.string = strdup(yytext);return MINUS;}
"+"         {yylval.string = strdup(yytext);return PLUS;}
"*"         {yylval.string = strdup(yytext);return MULT;}
"/"         {yylval.string = strdup(yytext);return DIVIDE;}
"&"         {yylval.string = strdup(yytext);return VARIABLE_PREIDENTIFIER;}     
"("         {yylval.string = strdup(yytext);return OPEN_PARANTHESIS;}
")"         {yylval.string = strdup(yytext);return CLOSE_PARANTHESIS;}
"le"        return LESSOREQUAL;
"ee"        return EQUAL;
"ne"        return NOTEQUAL;
"lt"         return LESSTHAN;
"gt"         return GREATERTHAN;
"ge"        return GREATEROREQUAL;

[A-Za-z][A-Za-z0-9_]*       {yylval.string = strdup(yytext);return IDENTIFIER;}
[A-Za-z]+                   {yylval.string = strdup(yytext);return CHAR;}
([0-9]+\.[0-9]+)            {yylval.string = strdup(yytext);return FLOAT;}
[0-9]+                      {yylval.string = strdup(yytext);return INTEGER;}
\n	                        {linenumber++;} 
("# ".*)                    {yylval.string = strdup(yytext);return COMMENT;}
[\t ]+	                    {tabnum++;}
.           {ECHO; yyerror("unexpected character");}

%%
int yywrap (void) {return 1;}