install:
	sudo apt-get update
	sudo apt-get upgrade
	sudo apt-get install wget
	# Install .NET5.0
	wget https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
	sudo dpkg -i packages-microsoft-prod.deb
	sudo apt-get update
	sudo apt-get install -y apt-transport-https
	sudo apt-get update
	sudo apt-get install -y dotnet-sdk-5.0
	dotnet --info
	dotnet tool install -g dotnet-ef
	# Install Docker
	sudo snap install docker
run:
	#Init Docker-Postgres
	sudo docker run --name some-postgres -e POSTGRES_PASSWORD=mysecretpassword -d postgres
	# Init ASP.NET project
	dotnet ef database update --project ./sistema/sistema.csproj
	dotnet restore
	dotnet clean
	dotnet run --project ./sistema/sistema.csproj
	
clean:
	#Init Docker-Postgres
	sudo docker rm some-postgres -f
	# Init ASP.NET project
	sudo snap remove docker
	sudo apt-get purge dotnet-sdk-5.0

