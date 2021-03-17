start:
	dotnet restore
	dotnet clean
	dotnet run --project ./sistema/sistema.csproj
watch:
	dotnet watch --project ./sistema/sistema.csproj run