FROM mcr.microsoft.com/dotnet/sdk:5.0

COPY . /app

WORKDIR /app
COPY . ./
# CMD dotnet run
RUN dotnet publish -o publish
CMD dotnet /app/publish/docker.dll

# docker build -t docker-console .
# docker run docker-console