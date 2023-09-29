
create procedure selectsp
as
begin

select * from dbo.players
end

exec selectsp

-------- insert --------




 

 create  procedure insertsp (@player_id int,@player_name nvarchar(100),@game nvarchar(40),@player_salary int,@age int)
as
begin
 insert into dbo.players (player_id,player_name,game,player_salary,age) values (@player_id,@player_name,@game,@player_salary,@age)
	
end

exec insertsp 1,'Indhu','Boxing',1000,40
-----------------update--------------

create  procedure updatesp (@player_name nvarchar(100),@game nvarchar(40),@player_salary int,@age int,@player_id int)

as 
begin
update dbo.players set 

player_name=@player_name,
game=@game,
player_salary=@player_salary,
age=@age

where  player_id=@player_id

end 
exec updatesp --'harish','swimming',45000,40,1


------------delete-----------------
create procedure deletesp (@player_id int)
as
begin

delete from dbo.players where player_id=@player_id
end

exec deletesp 4











