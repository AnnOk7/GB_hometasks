/*
mySQL Final Test (Okorokova Anna)

I. Создайте процедуру, которая принимает кол-во сек и формат их в кол-во дней часов. Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds '
II. Создайте функцию, которая выводит только четные числа от 1 до 10. Пример: 2,4,6,8,10 
*/

-- I. Создайте процедуру, которая принимает кол-во сек и формат их в кол-во дней часов. Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds '
DROP PROCEDURE proc1;
DELIMITER //
CREATE PROCEDURE proc1(seconds INT)
BEGIN 
	DECLARE days INT default 0;
    DECLARE hours INT default 0;
    DECLARE minutes INT default 0;
    
    WHILE seconds >= 84600 DO  -- 24Ч = 84600СЕК
    SET days = seconds / 84600;
    SET seconds = seconds % 84600;
    END WHILE;

    WHILE seconds >= 3600 DO  -- 1Ч = 3600СЕК
    SET hours = seconds / 3600;
    SET seconds = seconds % 3600;
    END WHILE;

    WHILE seconds >= 60 DO
    SET minutes = seconds / 60;
    SET seconds = seconds % 60;
    END WHILE;

SELECT days, hours, minutes, seconds;
    
END //
DELIMITER ;

CALL proc1(360000);



-- II. Создайте функцию, которая выводит только четные числа от 1 до 10. Пример: 2,4,6,8,10 
-- 1 вариант работающий
DELIMITER $$
CREATE PROCEDURE numbers()
BEGIN
    DECLARE n INT default 0;
    DROP TABLE IF EXISTS nums;
    CREATE TABLE nums (n INT);

    WHILE n < 10 DO
    SET n = n + 2;
    INSERT INTO nums VALUES(n);
    END WHILE;

SELECT * FROM nums;
END $$
DELIMITER ;

CALL numbers();


-- 2 вариант , почему-то неработающий
DROP PROCEDURE numbers IF EXISTS 
DELIMITER //
CREATE PROCEDURE numbers()
BEGIN
    DECLARE n INT default 0;
    DROP TABLE IF EXISTS nums;
    CREATE TABLE nums (n INT);

    WHILE n <= 100 DO
    IF n % 2 = 0 THEN
		SET result = CONCAT(result, n, ",");
        END IF;
        SET n = n + 2;
    INSERT INTO nums VALUES(n);
    END WHILE;
	    
SELECT * FROM nums;
END //
DELIMITER ;

CALL numbers();