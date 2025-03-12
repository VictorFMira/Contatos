
var builder = WebApplication.CreateBuilder(args);

// Adicionar o contexto do EF Core
builder.Services.AddDbContext<ContatoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
