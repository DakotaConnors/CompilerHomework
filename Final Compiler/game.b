LET myhealth = 3
LET enemyhealth = 5
LET done = 0
LET a = 0
LET message = "empty"
LET name1 = "MY_HEALTH"
LET name2 = "ENEMY_HEALTH"
WHILE done = 0
PRINT name1
PRINT myhealth
PRINT name2
PRINT enemyhealth
INPUT $a
IF a = 1 : LET enemyhealth = enemyhealth - 1
IF a = 2 : LET myhealth = myhealth + 2
LET myhealth = myhealth - 1
IF enemyhealth = 0 : LET done = 1
IF myhealth = 0 : LET done = 2
END
IF done = 1 : LET message = "WINNER!"
IF done = 2 : LET message = "LOSER!"
PRINT message