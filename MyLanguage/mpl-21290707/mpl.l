%{
#include "y.tab.h"
%}

%%

[ \t\n]+    
":"           { return COLON; }
"i"           { return INT; }
"f"           { return FLOAT; }
"c"           { return CHAR; }
"\+"          { return PLUS; }
"-"           { return MINUS; }
"\*"          { return MULT; }
"/"           { return DIV; }
"?"           { return IF; }
"??"          { return ELSEIF; }
"???"         { return ELSE; }
"while"       { return WHILE; }
">"           { return GREATER_THAN; }
"<"           { return LESS_THAN; }
"=="          { return EQUAL_EQUAL; }
"!="          { return NOT_EQUAL; }
">="          { return GREATER_EQUAL; }
"<="          { return LESS_EQUAL; }
"="           { return EQUAL; }
"bunuyaz"     { return PRINT; }
"("           { return LPAREN; }
")"           { return RPAREN; }
[a-zA-Z][a-zA-Z0-9]* { yylval.strval = strdup(yytext); return ID; }
[0-9]+        { yylval.intval = atoi(yytext); return NUM; }

%%

int yywrap(void) {
    return 1;
}
