# build stage
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
COPY . ./
RUN dotnet publish -c Release -o output

# serve stage
FROM nginx:alpine
WORKDIR /var/www/web
COPY --from=build /app/output/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf
EXPOSE 80
