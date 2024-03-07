using Microsoft.AspNetCore.Mvc;

namespace Abdul9A.Controllers
{
    //[Route("Home")]     //ager mai is tarah se Route ko set kar deta hun to niche 
    //hum ko sub me bar bar Home ko likhne ki zarurat nahi padti hai wo yha se catch
    //ho jata hai   ye similer requestmapping ki tarah kam kar rah hai taki same 
    //chees ko bar bar na likhna pade 


    //[Route("controller")]  //yha sirf controller likhna hota hai wo automatic wo 
    //automatic catch karta hai 

    //[Route("controller")]/[action]")]  //ager mai is tarah se likha deta hun to 
    //jo niche bar bar har view ke sath action ko likhna pad raha tha usko nahi 
    //likhna padega it is also a way

    public class HomeController : Controller
    {
        [Route("")]  //yha hum ne empty route ko define kiya hai to us hisab se kya 
        //hota hai ki pahla wala chalta hai to Index() wala chalega 
        
        [Route("Home")]
        
        [Route("Home/Index")]  //hum multiple route ko bana sakte hai lekin sub me 
                               //parameter ka diffrence hona chahiye 
                               //ye teeno aik hi kam karenge Index() wale view ko execute karte hai 
        
        [Route("~/")]   //ye tab chalte hai jab hum request pass karte hai aur usme 
        //kuch pass nahi karte hai to us case me ye chalta hai to us hisab se Index 
        //wala chalga 
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/About")]
        
        //[Route("action")]    //yha sirf action ko hum likhte hai to wo automatically 
        //har action ko match kar ke execute hoga jis hisab se URL se request aati hai 
        //us hisab se ye excute hota hai 
        public IActionResult About()
        {
            return View();
        }

        //[Route("Home/Details/{id}")]
        
        [Route("Home/Details/{id?}")]   //ager mai is tarah se likh deta hun to
        //id jo hai wo optional ho jati hai to is case me hum id pass nahi karenge 
        //to bhi Details execute hoga to us case me id ki integer default value 
        //assign ho jai gi 
        
        //[Route("action")]
        
        public int Details(int id)
        //public int Details(int? id)   //hum is tarah likh kar ye bta rahe hai ki
        //ager mai id me kuch pass nahi karta hun to usme null value assign ho jai 
        {
            return id;
            //return ?? 1;  //yha check ho rha hai ki kya id ki null value hai to usme 
            //1 put kar do 
        }
    }
}
