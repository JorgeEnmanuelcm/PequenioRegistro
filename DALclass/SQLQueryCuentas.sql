create database Cuentasdb

use Cuentasdb

create table Cuentas(
CuentaId int identity(1,1),
Balance float,
Descripcion varchar(100))


select *from Cuentas

drop table cuentas