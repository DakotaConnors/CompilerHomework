all : MyCompiler

lex.yy.c : MyCompiler.l
	flex MyCompiler.l
	
MyCompiler.tab.h MyCompiler.tab.c : MyCompiler.y
	bison -d -o MyCompiler.tab.c MyCompiler.y
	
MyCompiler : lex.yy.c MyCompiler.tab.c MyCompiler.tab.h
	cl lex.yy.c MyCompiler.tab.c /link /out:MyCompiler