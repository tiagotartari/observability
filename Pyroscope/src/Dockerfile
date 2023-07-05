FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

RUN apt-get update && apt-get -y install wget
RUN wget -qO- https://github.com/grafana/pyroscope-dotnet/releases/download/v0.8.4-pyroscope/pyroscope.glibc.tar.gz  \
     | tar xvz

EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Demo.Pyroscope.csproj", "."]
RUN dotnet restore "./Demo.Pyroscope.csproj"

COPY . .
WORKDIR "/src/."
RUN dotnet build "Demo.Pyroscope.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Demo.Pyroscope.csproj" -c Release -o /app/publish -r $(dotnet --info | grep RID | cut -b 6- | tr -d ' ')

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV CORECLR_ENABLE_PROFILING=1
ENV CORECLR_PROFILER={BD1A650D-AC5D-4896-B64F-D6FA25D6B26A}
ENV CORECLR_PROFILER_PATH=/app/Pyroscope.Profiler.Native.so
ENV LD_PRELOAD=/app/Pyroscope.Linux.ApiWrapper.x64.so

ENV PYROSCOPE_LOG_LEVEL=info
ENV PYROSCOPE_PROFILING_ENABLED=1
ENV PYROSCOPE_PROFILING_ALLOCATION_ENABLED=true
ENV PYROSCOPE_PROFILING_CONTENTION_ENABLED=true
ENV PYROSCOPE_PROFILING_EXCEPTION_ENABLED=true

ENTRYPOINT ["dotnet", "/app/Demo.Pyroscope.dll"]