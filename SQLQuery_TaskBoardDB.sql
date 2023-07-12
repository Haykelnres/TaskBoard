go 
create database TaskBoardDB

create table taskData(
	taskID int IDENTITY NOT NULL PRIMARY KEY,
	taskName varchar(200) NOT NULL,
)

create table specificTasks(
	specificTasksID int IDENTITY NOT NULL PRIMARY KEY,
	specificTasksName varchar(200) NOT NULL,
	specificTasksWorkerID int NOT NULL,
	specificTasksDateOfStart date NOT NULL,
	specificTasksDateOfActualEnd date NULL,
	specificTasksDateOfEnd date NULL,
	specificTasksStatus varchar(15) NULL,
	specificTasksCommentary varchar(500) NULL,
	specificTasksWarn varchar(500) NULL,
	taskID int NOT NULL
)
create table Performers(
	performerID int identity not null primary key,
	performerName varchar(200) not null
)

ALTER TABLE specificTasks
   ADD CONSTRAINT FK_taskID_taskData FOREIGN KEY (taskID)
      REFERENCES taskData (taskID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE specificTasks
   ADD CONSTRAINT FK_workerId_taskData FOREIGN KEY (specificTasksWorkerID)
      REFERENCES Performers (performerID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;

