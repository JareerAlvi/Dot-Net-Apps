Create Chatting_App;
USE Chatting_App;
GO

-- Table: tbUsers
CREATE TABLE tbUsers (
    ContactNumber VARCHAR(20) PRIMARY KEY,
    Name          VARCHAR(100) NOT NULL,
    Password      VARCHAR(255) NOT NULL
);
GO

CREATE TABLE tbContacts (
    UserContactNumber VARCHAR(20) NOT NULL,
    ContactNumber     VARCHAR(20) NOT NULL,
    AddedOn           DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (UserContactNumber, ContactNumber),
    FOREIGN KEY (UserContactNumber) REFERENCES tbUsers(ContactNumber) ON DELETE CASCADE,
    FOREIGN KEY (ContactNumber) REFERENCES tbUsers(ContactNumber) ON DELETE NO ACTION
);
GO

-- Table: tbMessages
CREATE TABLE tbMessages (
    MessageId        INT IDENTITY(1,1) PRIMARY KEY,
    SenderContact    VARCHAR(20) NOT NULL,
    ReceiverContact  VARCHAR(20) NOT NULL,
    Content          TEXT NOT NULL,
    SentAt           DATETIME DEFAULT GETDATE(),
    IsRead           BIT DEFAULT 0,
    FOREIGN KEY (SenderContact) REFERENCES tbUsers(ContactNumber) ON DELETE CASCADE,
    FOREIGN KEY (ReceiverContact) REFERENCES tbUsers(ContactNumber) ON DELETE NO ACTION
);
GO