# Proyecto ASP.NET MVC con Entity Framework

Este es un proyecto básico de ASP.NET MVC que utiliza Entity Framework para realizar operaciones CRUD en una base de datos SQL Server.

## **Requisitos previos**

Antes de comenzar, asegúrate de tener instalado lo siguiente:

- [Visual Studio](https://visualstudio.microsoft.com/) (preferiblemente 2019 o superior).
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (versión 4.7.2 o superior).
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (puede ser local o en un contenedor Docker).
- [Git](https://git-scm.com/) (para gestionar el control de versiones).

## **Configuración del proyecto**

### 1. Clonar el repositorio

Primero, clona este repositorio en tu máquina local:

```bash
git clone https://github.com/tu-usuario/tu-repositorio.git
cd tu-repositorio
```
### 2. Configurar conexiones y base de datos
Asegurarse que la base de datos se encuentra en linea, se usan los siguientes comandos, ejemplo docker
```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=TuContraseñaSegura" -p 1433:1433 --name sql-server -d mcr.microsoft.com/mssql/server:2022-latest
```
Actualizar la cadena de conexion en web.config

```bash
<connectionStrings>
    <add name="ApplicationDbContext" 
         connectionString="Server=192.168.100.18,1433;Database=NombreDeTuBaseDeDatos;User Id=tuUsuario;Password=tuContraseña;"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```
### 3. Creamos las migraciones
Se abre la consola de nugget y ejecutamos lo siguiente
```bash
Update-Database
```
### 4. Ejecutamos lla aplicacion

Si todo sale bien le damos F5 en visual studio y se ejecutara en el navegador

para ingresar a la vista solo hay que ir a "/Products" dentro de nuetro servidor



