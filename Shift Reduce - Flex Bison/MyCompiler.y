%{
#include <stdio.h>
#include <string.h>
#include "MyCompiler.h"
  void yyerror(const char *str);
  int yywrap();
  int yylex();
char *identifiers[100];
%}

%start line
%token NUM
%token ASSIGN
%token START
%token STOP
%token ID
%token WS
%token EOL
%token OPERATOR

%%

line :
     |
     command
     |
     line command
     ;

command :
     start_command {;}
     |
     stop_command {;}
     |
     assignment_command {;}
     ;

assignment_command :
     ASSIGN WS ID WS OPERATOR WS NUM{printf("assignment command");}
     ;

start_command :
     START WS ID EOL{printf("Starting Program\n");}
     ;

stop_command :
     optional_ws STOP optional_ws {printf("stop command");}
     ;

optional_ws :
     /* empty */
     |
     WS
     ;

%%
void yyerror(const char *str)
{
  fprintf(stderr,"found an error: %s\n",str);
}
int main(int argc, char *argv[])
{
  return yyparse();
}