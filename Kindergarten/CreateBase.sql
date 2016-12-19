CREATE TABLE [Parent] (
	id uniqueidentifier NOT NULL,
	surname nvarchar(30) NOT NULL,
	name nvarchar(20) NOT NULL,
	phone numeric(12) NOT NULL,
	address nvarchar(100) NOT NULL,
  CONSTRAINT [PK_PARENT] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Child] (
	id uniqueidentifier NOT NULL,
	surname nvarchar(30) NOT NULL,
	name nvarchar(20) NOT NULL,
	DOB date NOT NULL,
	group_id uniqueidentifier NOT NULL,
  CONSTRAINT [PK_CHILD] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Group] (
	id uniqueidentifier NOT NULL,
	name nvarchar(20) NOT NULL,
	training_plan binary,
  CONSTRAINT [PK_GROUP] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Child_of_parent] (
	parent_id uniqueidentifier NOT NULL,
	child_id uniqueidentifier NOT NULL
)
GO
CREATE TABLE [Employee] (
	id uniqueidentifier NOT NULL,
	surname nvarchar(30) NOT NULL,
	name nvarchar(20) NOT NULL,
	phone numeric(12) NOT NULL UNIQUE,
	address nvarchar(50) NOT NULL UNIQUE,
	post_id uniqueidentifier NOT NULL,
  CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Post] (
	id uniqueidentifier NOT NULL,
	name nvarchar(20) NOT NULL,
  CONSTRAINT [PK_POST] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Employee_of_group ] (
	employee_id uniqueidentifier NOT NULL,
	group_id uniqueidentifier NOT NULL
)
GO
CREATE TABLE [User] (
	id uniqueidentifier NOT NULL,
	login nvarchar(30) NOT NULL UNIQUE,
	password nvarchar(30) NOT NULL,
  CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [Child] WITH CHECK ADD CONSTRAINT [Child_fk0] FOREIGN KEY ([group_id]) REFERENCES [Group]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Child] CHECK CONSTRAINT [Child_fk0]
GO


ALTER TABLE [Child_of_parent] WITH CHECK ADD CONSTRAINT [Child_of_parent_fk0] FOREIGN KEY ([parent_id]) REFERENCES [Parent]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Child_of_parent] CHECK CONSTRAINT [Child_of_parent_fk0]
GO
ALTER TABLE [Child_of_parent] WITH CHECK ADD CONSTRAINT [Child_of_parent_fk1] FOREIGN KEY ([child_id]) REFERENCES [Child]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Child_of_parent] CHECK CONSTRAINT [Child_of_parent_fk1]
GO

ALTER TABLE [Employee] WITH CHECK ADD CONSTRAINT [Employee_fk0] FOREIGN KEY ([post_id]) REFERENCES [Post]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Employee] CHECK CONSTRAINT [Employee_fk0]
GO


ALTER TABLE [Employee_of_group ] WITH CHECK ADD CONSTRAINT [Employee_of_group _fk0] FOREIGN KEY ([employee_id]) REFERENCES [Employee]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Employee_of_group ] CHECK CONSTRAINT [Employee_of_group _fk0]
GO
ALTER TABLE [Employee_of_group ] WITH CHECK ADD CONSTRAINT [Employee_of_group _fk1] FOREIGN KEY ([group_id]) REFERENCES [Group]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [Employee_of_group ] CHECK CONSTRAINT [Employee_of_group _fk1]
GO

