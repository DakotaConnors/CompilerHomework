grammar antlrParser;

options {
    language=CSharp;
}

prog : (LINE + OPTIONAL_EOL)* ;         

OPTIONAL_EOL : EOL
               | ;
               
EOL : [\r\n] ;

LINE : NUMBER + OPERATOR + NUMBER
	   |
	   NUMBER
	   ;


OPERATOR : '+' {Console.WriteLine("Found a +");}
           |
           '-'
           |
           '*'
           |
           '/'
           ;

ID : [a-z]+
     ;             

NUMBER : [0-9]+
         ;

OPTIONAL_WS : [ \t]+
              |
              ;
