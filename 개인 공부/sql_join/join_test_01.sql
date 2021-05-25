-- CREATE TABLE `author` (
--   `aid` int(11) NOT NULL,
--   `name` varchar(10) DEFAULT NULL,
--   `city` varchar(10) DEFAULT NULL,
--   `profile_id` int(11) DEFAULT NULL,
--   PRIMARY KEY (`aid`)
-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
-- INSERT INTO `author` VALUES (1,'egoing','seoul',1),(2,'leezche','jeju',2),(3,'blackdew','namhae',3);

-- CREATE TABLE `profile` (
--   `pid` int(11) NOT NULL,
--   `title` varchar(10) DEFAULT NULL,
--   `description` tinytext,
--   PRIMARY KEY (`pid`)
-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
-- INSERT INTO `profile` VALUES (1,'developer','developer is ...'),(2,'designer','designer is ..'),(3,'DBA','DBA is ...');
 
-- CREATE TABLE `topic` (
--   `tid` int(11) NOT NULL,
--   `title` varchar(45) DEFAULT NULL,
--   `description` tinytext,
--   `author_id` varchar(45) DEFAULT NULL,
--   PRIMARY KEY (`tid`)
-- ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
-- INSERT INTO `topic` VALUES (1,'HTML','HTML is ...','1'),(2,'CSS','CSS is ...','2'),(3,'JavaScript','JavaScript is ..','1'),(4,'Database','Database is ...',NULL);


-- SELECT * FROM topic;

-- SELECT * FROM topic LEFT JOIN author ON topic.author_id = author.aid;

-- SELECT * FROM topic LEFT JOIN author ON topic.author_id = author.aid LEFT JOIN profile ON author.profile_id = profile.pid;

-- SELECT tid, topic.title, author_id, NAME, profile.title FROM topic LEFT JOIN author ON topic.author_id = author.aid LEFT JOIN profile ON author.profile_id = profile.pid;
-- SELECT tid, topic.title, author_id, NAME, profile.title AS job_title FROM topic LEFT JOIN author ON topic.author_id = author.aid LEFT JOIN profile ON author.profile_id = profile.pid;

-- SELECT tid, topic.title, author_id, NAME, profile.title AS job_title FROM topic LEFT JOIN author ON topic.author_id = author.aid LEFT JOIN profile ON author.profile_id = profile.pid WHERE aid = 1;



-- SELECT * FROM topic INNER JOIN author ON topic.author_id = author.aid;

-- SELECT * FROM topic INNER JOIN author ON topic.author_id = author.aid INNER JOIN profile ON profile.pid=author.profile_id;



-- SELECT * FROM topic FULL outer JOIN author ON topic.author_id = author.aid;
-- SELECT * FROM topic left JOIN author ON topic.author_id = author.aid UNION SELECT * FROM topic RIGHT JOIN author ON topic.author_id=author.aid;



SELECT * FROM topic LEFT JOIN author ON topic.author_id = author.aid WHERE author.aid IS null;