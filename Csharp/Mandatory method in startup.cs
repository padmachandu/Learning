ConfigureServices(IServiceCollection services) – used to register services with the dependency injection (DI) container.

Configure(IApplicationBuilder app, IWebHostEnvironment env) – used to define the HTTP request processing pipeline (middleware).

👉 Out of these, the only mandatory method is Configure.

If you don’t provide ConfigureServices, the framework will still work (it just won’t register any extra services, only built-in defaults).

But without Configure, ASP.NET Core won’t know how to handle incoming HTTP requests, and the application will fail to run properly.

✅ Answer:
The mandatory method in Startup.cs is Configure.
