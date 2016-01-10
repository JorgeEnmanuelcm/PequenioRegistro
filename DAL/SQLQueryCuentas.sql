create database Cuentasdb

use Cuentasdb

create table Cuentas(
CuentaId int identity(1,1),
Descripcion varchar(100),
Balance float)  

select *from Cuentas