\connect recipiehub

CREATE TABLE recipie
(
    id INT PRIMARY KEY,
    title VARCHAR(50) NOT NULL,
    description VARCHAR(250) NOT NULL
);

ALTER TABLE "recipie" OWNER TO dbuser

INSERT INTO recipie(title, description) 
VALUES 
    ( 'recipie 1', 'totally rad'), 
    ( 'recipie 2', 'totally gross')