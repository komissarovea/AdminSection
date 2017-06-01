cd adminsection
set DOTNET_SKIP_FIRST_TIME_EXPERIENCE=true
dotnet --info
dotnet restore
dotnet run --server.urls http://0.0.0.0:5005