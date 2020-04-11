use Marlene

Create Table Concert 
(
ConcertId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
ConcertName varchar (50),
ConcertDate date,
NumberOfTickets int,
NumberOfTicketsSold int,
TicketPrice decimal(5,2)
)

Create Table Musician 
(
MusicianId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
MusicianName varchar (50),
Instrument varchar (30),
Fee decimal(6,2)
)



insert into Concert 
(ConcertName, ConcertDate, NumberOfTickets, NumberOfTicketsSold, TicketPrice)
values ('JBC Autumn Concert', '5 Apr 2020', 400,20, 150.00)

select * from Concert

insert into Musician 
(MusicianName, Instrument, Fee)
values ('Tim Roberts', 'Oboe', 4000.00),
('Ruth Coggin', 'Organ', 3000.00)

select * from Musician



Create Table ConcertMusician 
(
ConcertMusicianId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
ConcertId int,
MusicianId int,
CONSTRAINT FK_Concert FOREIGN KEY (ConcertId)
REFERENCES Concert(ConcertId),
CONSTRAINT FK_Musician FOREIGN KEY (MusicianId)
REFERENCES Musician(MusicianId)
)



Insert into ConcertMusician
(ConcertId, MusicianId)
VALUES
((select c.ConcertId from Concert c where c.ConcertName = 'JBC Autumn Concert'),
(select m.MusicianId from Musician m where m.Instrument = 'Oboe')
)

Insert into ConcertMusician
(ConcertId, MusicianId)
VALUES
((select c.ConcertId from Concert c where c.ConcertName = 'JBC Autumn Concert'),
(select m.MusicianId from Musician m where m.Instrument = 'Organ')
)


select * from ConcertMusician