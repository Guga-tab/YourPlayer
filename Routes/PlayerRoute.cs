using Microsoft.EntityFrameworkCore;
using YourPlayer.Data;
using YourPlayer.Models;

namespace YourPlayer.Routes
{
    public static class PlayerRoute
    {
        public static void PlayerRoutes(this WebApplication app)
        {
            var route = app.MapGroup("player");
            
            route.MapGet("", 
                async (PlayerContext ctx) =>
                {
                   var player = await ctx.Player.ToListAsync(); 
                   return Results.Ok(player);
                });

            route.MapGet("{id:guid}", 
                async (Guid id, PlayerContext ctx) =>
                {
                   var player = await ctx.Player.FindAsync(id);
                   
                   if(player == null)
                        return Results.NotFound();
               
                   return Results.Ok(player);
                });
            
            route.MapPost("", 
                async (PlayerRequest req, PlayerContext ctx) =>
                {
                    var player = new PlayerModel(req.name,req.age, req.nationality, req.position);
                    await ctx.AddAsync(player);
                    await ctx.SaveChangesAsync();
                });

            route.MapPut("{id:guid}", 
                async (Guid id, PlayerRequest req, PlayerContext ctx) =>
                {
                    var player = await ctx.Player.FindAsync(id);

                    if(player == null)
                        return Results.NotFound();
                    
                    player.Name = req.name;
                    player.Age = req.age;
                    player.Nationality = req.nationality;
                    player.Position = req.position;

                    await ctx.SaveChangesAsync();

                    return Results.Ok(player);
                });

            route.MapDelete("{id:guid}",
                async (Guid id, PlayerContext ctx) =>
                {
                    var player = await ctx.Player.FindAsync(id);

                    if(player == null)
                        return Results.NotFound();

                    player.SetInactive();

                    await ctx.SaveChangesAsync();

                    return Results.Ok(player);
                });
        }
    }
}