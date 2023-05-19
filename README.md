# Continuous Profiling and Observability in .NET

This repository is dedicated to exploring and demonstrating the implementation of continuous profiling and observability in .NET applications.

Observability is a crucial feature for any production application, as it allows developers to understand what's happening inside the system and identify potential issues.

**The projects in this repository must not be replicated in production, use only as a study.**

## What is Continuous Profiling?

Continuous Profiling is a performance data collection technique that continuously records profile information from a system. Unlike traditional profiling, which is typically only enabled during development or testing, Continuous Profiling is used on systems in production. This allows you to identify problems that only appear under real working conditions.

This practice allows developers to proactively identify performance problems and bottlenecks in production, helping to reduce the MTTR (Mean Time to Resolution). [To learn more about Continuous Profiling, visit this link.](https://tiagotartari.net/continuous-profiling-como-identificar-problemas-em-producao-e-reduzir-o-mttr.html)

## Pyroscope in .NET

This project focuses on integrating Pyroscope, an open-source application performance analysis platform, with a .NET application. Our goal is to demonstrate how it's possible to obtain detailed, real-time insights into application performance using Pyroscope.

### Why Pyroscope?
Pyroscope offers continuous profiling, allowing us to understand the behavior of our code during production execution. With it, we can identify performance bottlenecks, optimize resource usage, and ultimately improve the overall quality of our software. [Learn more about Pyroscope here.](https://pyroscope.io/)

## Useful Links

-   [Continuous Profiling: How to Identify Problems in Production and Reduce MTTR](https://tiagotartari.net/continuous-profiling-como-identificar-problemas-em-producao-e-reduzir-o-mttr.html)
-   [Official Pyroscope Website](https://pyroscope.io/)

Feel free to explore the code, experiment on your own, and contribute improvements and ideas. This is a space for learning and growing as a community of .NET developers focused on building observable, high-performance applications.
