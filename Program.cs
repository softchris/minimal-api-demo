using Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
 
if (app.Environment.IsDevelopment()){ app.UseDeveloperExceptionPage(); }

RoutesBuilder.Setup(app);
 
app.Run();
