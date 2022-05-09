docker-compose up -d db
wsl -d docker-desktop sysctl -w vm.max_map_count=262144
dotnet tool install --global dotnet-sonarscanner
dotnet tool install --global dotnet-coverage
docker exec sonar-db-container psql -d postgres -c "CREATE DATABASE sonar"

docker-compose up sonarqube

