%option noyywrap

%{
#include <stdio.h>
#include <assert.h>
#include <string.h>
#include "MyCompiler.h"
#include "MyCompiler.tab.h"
%}

%%
[0-9]+                  {
  printf("'%s' is NUMBER\n",yytext);
  return NUM;
}

LET {
  printf("'%s' is ASSIGN\n", yytext);
  return ASSIGN;
}

PROGRAM {
  printf("'%s' is START\n", yytext);
  return START;
}

END {
  printf("'%s' is STOP\n", yytext);
  return STOP;
}

(_|[a-zA-Z])([a-zA-Z]|[0-9])* {
  printf("'%s' is ID\n", yytext);
  return ID;
}

[ \t] {
  printf("'%s' is WS\n", yytext);
  return WS;
}

\r?\n {
  printf("EOL\n");
  return EOL;
}

[+|-|*|/|=] {
  printf("'%s' is OPERATOR", yytext);
  return OPERATOR;
}

. {
  printf("syntax Error '%s'\n", yytext);
}



%%