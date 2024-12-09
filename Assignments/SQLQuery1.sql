-- Create the database
USE Master;
	DROP DATABASE IF EXISTS VideoGameReviews;
	CREATE DATABASE VideoGameReviews;
	ALTER DATABASE VideoGameReviews
		COLLATE Latin1_General_CI_AS;
	GO

-- Use the database
USE VideoGameReviews;

DROP TABLE IF EXISTS Reviews;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Games;
DROP PROCEDURE IF EXISTS spGamesByGenre;
DROP PROCEDURE IF EXISTS spInsertNewGame;
DROP PROCEDURE IF EXISTS spUpdateGame;
DROP PROCEDURE IF EXISTS spDeleteGame;
DROP PROCEDURE IF EXISTS spInsertNewUser;
DROP PROCEDURE IF EXISTS spUpdateUser;
DROP PROCEDURE IF EXISTS spDeleteUser;
DROP PROCEDURE IF EXISTS spInsertNewReview;
DROP PROCEDURE IF EXISTS spUpdateReview;
DROP PROCEDURE IF EXISTS spDeleteReview;

-- Create the tables

CREATE TABLE Games (
    GameID INT PRIMARY KEY,
    Title VARCHAR(100),
    Genre VARCHAR(50),
    ReleaseDate DATE
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    FirstName VARCHAR(50),
	LastName VARCHAR(50),
    Email VARCHAR(100) NOT NULL UNIQUE,
	PassKey INT NOT NULL,
	CONSTRAINT passkey_len_chk CHECK (PassKey BETWEEN 1000 AND 9999)
);

CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY,
    GameID INT,
    ReviewerID INT,
    Rating INT,
    ReviewText TEXT,
    ReviewDate DATE,
    FOREIGN KEY (GameID) REFERENCES Games(GameID),
    FOREIGN KEY (ReviewerID) REFERENCES Users(UserID)
);

-- ----------------------
-- Insert Data
-- ----------------------


-- Insert sample data into the Games table
INSERT INTO Games (GameID, Title, Genre, ReleaseDate) VALUES
(1, 'The Legend of Zelda: Breath of the Wild', 'Action-adventure', '2017-03-03'),
(2, 'The Witcher 3: Wild Hunt', 'Action RPG', '2015-05-19'),
(3, 'Minecraft', 'Sandbox', '2011-11-18'),
(4, 'Red Dead Redemption 2', 'Action-adventure', '2018-10-26'),
(5, 'Cyberpunk 2077', 'RPG', '2020-12-10'),
(6, 'God of War', 'Action-adventure', '2018-04-20'),
(7, 'Hades', 'Roguelike', '2020-09-17'),
(8, 'Among Us', 'Party', '2018-06-15'),
(9, 'Fortnite', 'Battle Royale', '2017-07-21'),
(10, 'Apex Legends', 'Battle Royale', '2019-02-04'),
(11, 'Animal Crossing: New Horizons', 'Simulation', '2020-03-20'),
(12, 'Doom Eternal', 'First-person shooter', '2020-03-20'),
(13, 'Final Fantasy VII Remake', 'RPG', '2020-04-10'),
(14, 'Ghost of Tsushima', 'Action-adventure', '2020-07-17'),
(15, 'Half-Life: Alyx', 'VR', '2020-03-23'),
(16, 'Resident Evil Village', 'Survival horror', '2021-05-07'),
(17, 'The Last of Us Part II', 'Action-adventure', '2020-06-19'),
(18, 'Sekiro: Shadows Die Twice', 'Action-adventure', '2019-03-22'),
(19, 'Super Mario Odyssey', 'Platform', '2017-10-27'),
(20, 'Horizon Zero Dawn', 'Action RPG', '2017-02-28');

-- Insert sample data into the Reviewers table
INSERT INTO Users (UserID, FirstName, LastName, Email, PassKey) VALUES
(1, 'John', 'Doe', 'john.doe@example.com', 1234),
(2, 'Jane', 'Smith', 'jane.smith@example.com', 2345),
(3, 'Alice', 'Johnson', 'alice.johnson@example.com', 3456),
(4, 'Bob', 'Brown', 'bob.brown@example.com', 4567),
(5, 'Charlie', 'Davis', 'charlie.davis@example.com', 5678);

-- Insert sample data into the Reviews table
INSERT INTO Reviews (ReviewID, GameID, ReviewerID, Rating, ReviewText, ReviewDate) VALUES
(1, 1, 1, 10, 'An amazing open-world experience with stunning visuals and gameplay.', '2023-01-15'),
(2, 2, 2, 9, 'A captivating story with deep characters and a vast world to explore.', '2023-02-20'),
(3, 3, 3, 8, 'A creative and endlessly replayable sandbox game.', '2023-03-10'),
(4, 4, 4, 9, 'A masterpiece of storytelling and gameplay.', '2023-04-05'),
(5, 5, 5, 7, 'A visually stunning game with some performance issues.', '2023-05-12'),
(6, 6, 1, 10, 'An epic journey with a compelling story and characters.', '2023-06-18'),
(7, 7, 2, 9, 'A challenging and rewarding roguelike experience.', '2023-07-22'),
(8, 8, 3, 8, 'A fun and engaging party game.', '2023-08-30'),
(9, 9, 4, 7, 'A popular battle royale game with frequent updates.', '2023-09-15'),
(10, 10, 5, 8, 'A fast-paced and exciting battle royale game.', '2023-10-10'),
(11, 11, 1, 9, 'A relaxing and charming simulation game.', '2023-11-05'),
(12, 12, 2, 9, 'A thrilling and intense first-person shooter.', '2023-12-20'),
(13, 13, 3, 8, 'A faithful and beautiful remake of a classic RPG.', '2024-01-15'),
(14, 14, 4, 9, 'A visually stunning and immersive action-adventure game.', '2024-02-10'),
(15, 15, 5, 10, 'A groundbreaking VR experience.', '2024-03-05'),
(16, 16, 1, 8, 'A terrifying and atmospheric survival horror game.', '2024-04-20'),
(17, 17, 2, 9, 'A powerful and emotional story with excellent gameplay.', '2024-05-15'),
(18, 18, 3, 9, 'A challenging and rewarding action-adventure game.', '2024-06-10'),
(19, 19, 4, 10, 'A delightful and imaginative platformer.', '2024-07-05'),
(20, 20, 5, 9, 'A visually stunning and engaging action RPG.', '2024-08-20'),
(21, 1, 2, 10, 'Still one of the best open-world games ever made.', '2024-09-15'),
(22, 2, 3, 9, 'The Witcher 3 continues to impress with its depth and storytelling.', '2024-10-10'),
(23, 3, 4, 8, 'Minecraft remains a timeless classic.', '2024-11-05'),
(24, 4, 5, 9, 'Red Dead Redemption 2 is a masterpiece.', '2024-12-20'),
(25, 5, 1, 7, 'Cyberpunk 2077 has improved but still has issues.', '2025-01-15'),
(26, 6, 2, 10, 'God of War is an epic journey.', '2025-02-10'),
(27, 7, 3, 9, 'Hades is a challenging and rewarding game.', '2025-03-05'),
(28, 8, 4, 8, 'Among Us is a fun party game.', '2025-04-20'),
(29, 9, 5, 7, 'Fortnite is still popular with frequent updates.', '2025-05-15'),
(30, 10, 1, 8, 'Apex Legends is a fast-paced battle royale game.', '2025-06-10'),
(31, 11, 2, 9, 'Animal Crossing: New Horizons is relaxing and charming.', '2025-07-05'),
(32, 12, 3, 9, 'Doom Eternal is a thrilling shooter.', '2025-08-20'),
(33, 13, 4, 8, 'Final Fantasy VII Remake is a beautiful remake.', '2025-09-15'),
(34, 14, 5, 9, 'Ghost of Tsushima is visually stunning.', '2025-10-10'),
(35, 15, 1, 10, 'Half-Life: Alyx is a groundbreaking VR game.', '2025-11-05'),
(36, 16, 2, 8, 'Resident Evil Village is terrifying.', '2025-12-20'),
(37, 17, 3, 9, 'The Last of Us Part II is powerful and emotional.', '2026-01-15'),
(38, 18, 4, 9, 'Sekiro: Shadows Die Twice is challenging.', '2026-02-10'),
(39, 19, 5, 10, 'Super Mario Odyssey is delightful.', '2026-03-05'),
(40, 20, 1, 9, 'Horizon Zero Dawn is visually stunning.', '2026-04-20');
GO

-- -------------------
-- Stored Procedures
-- -------------------

----------------
-- Games


CREATE OR ALTER PROCEDURE spGamesByGenre
	-- Add the parameters for the stored procedure here
	@genre VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT gameID, Title, Genre, ReleaseDate
	FROM games
	WHERE genre = @genre
	ORDER BY Title;
END
GO

-- Insert procedure for Games table
CREATE OR ALTER PROCEDURE spInsertNewGame
	@GameID INT,
    @Title VARCHAR(100),
    @Genre VARCHAR(50),
    @ReleaseDate DATE
AS
BEGIN
    INSERT INTO Games (GameID, Title, Genre, ReleaseDate)
    VALUES (@GameID, @Title, @Genre, @ReleaseDate);
END;
GO

-- Update procedure for Games table
CREATE OR ALTER PROCEDURE spUpdateGame
    @GameID INT,
    @Title VARCHAR(100),
    @Genre VARCHAR(50),
    @ReleaseDate DATE
AS
BEGIN
    UPDATE Games
    SET Title = @Title, Genre = @Genre, ReleaseDate = @ReleaseDate
    WHERE GameID = @GameID;
END;
GO
-- Delete procedure for Games table
CREATE OR ALTER PROCEDURE spDeleteGame
    @GameID INT
AS
BEGIN
    DELETE FROM Games
    WHERE GameID = @GameID;
END;
GO

------------------------------
-- Users

-- Insert New User sp
CREATE OR ALTER PROCEDURE spInsertNewUser
	@userID INT,
	@firstName VARCHAR(50),
	@lastName VARCHAR(50),
	@email VARCHAR(100),
	@PassKey INT
AS
BEGIN
	INSERT INTO users VALUES (@userID, @firstName, @lastName, @email, @passKey);
END
GO

-- Update User sp
CREATE OR ALTER PROCEDURE spUpdateUser
	@userID INT,
	@firstName VARCHAR(50),
	@lastName VARCHAR(50),
	@email VARCHAR(100),
	@PassKey INT
AS
BEGIN
	UPDATE users SET
		firstName = @firstName, 
		lastName = @lastName, 
		email = @email, 
		passKey = @passKey
	WHERE userID = @userID;
END
GO

-- Delete User SP
CREATE OR ALTER PROCEDURE spDeleteUser
	@userID INT
AS 
BEGIN
	DELETE FROM users WHERE userID = @userID;
END
GO

-- ---------------
-- Reviews
-- Insert procedure for Reviews table
CREATE PROCEDURE spInsertNewReview
    @GameID INT,
    @UserID INT,
    @Rating INT,
    @ReviewText TEXT,
    @ReviewDate DATE
AS
BEGIN
    INSERT INTO Reviews (GameID, ReviewID, Rating, ReviewText, ReviewDate)
    VALUES (@GameID, @UserID, @Rating, @ReviewText, @ReviewDate);
END;
GO

-- Update procedure for Reviews table
CREATE PROCEDURE spUpdateReview
    @ReviewID INT,
    @GameID INT,
    @ReviewerID INT,
    @Rating INT,
    @ReviewText TEXT,
    @ReviewDate DATE
AS
BEGIN
    UPDATE Reviews
    SET GameID = @GameID, ReviewerID = @ReviewerID, Rating = @Rating, ReviewText = @ReviewText, ReviewDate = @ReviewDate
    WHERE ReviewID = @ReviewID;
END;
GO

-- Delete procedure for Reviews table
CREATE PROCEDURE spDeleteReview
    @ReviewID INT
AS
BEGIN
    DELETE FROM Reviews
    WHERE ReviewID = @ReviewID;
END;
GO
