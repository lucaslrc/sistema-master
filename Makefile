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
	# Install Docker
	wget https://download.docker.com/linux/static/stable/x86_64/docker-20.10.5.tgz
	tar xzvf docker-20.10.5.tgz
	sudo cp docker/* /usr/bin
run:
	sudo dockerd &
	sudo docker run --name some-postgres -e POSTGRES_PASSWORD=mysecretpassword -d postgres
	# Init ASP.NET project
	dotnet restore
	dotnet clean
	dotnet run --project ./sistema/sistema.csproj
