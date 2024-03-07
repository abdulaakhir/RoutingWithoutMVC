var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();   //Routing perform karne ke liye is line ko add 
//karna padta hai 

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapDefaultControllerRoute();   //Ager mai sirf is line ko likhta hun to ye bydefault home 
//controller ke index method ko call kar pata hai aur chesse execute ho jati hai lekin hum ko
//ager apne hisab se controller ko call karna hai and action ko call karna hai to niche jis
//tarah likha hai us tarah hum ko bhi likhna hota hai is formate me 

/////////////// Conventional Based Routing /////////////////////////////////
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=User}/{action=Index}/{id?}"  //yahi se call hota hai 
//    //pahle controller call hota hai phir vhi se view call hota hai is tarah se
//    //hum jo jo controller and action me change karte hai us hisab se sari chess
//    //change hoti hai   
//    );


//////////////  Atribute based Routing   ////////////////////////////////
app.MapControllers();   //Is Middle ware ka use attribute based routing ke liye use
//karte hai 


app.Run();
