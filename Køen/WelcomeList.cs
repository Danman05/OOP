﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class WelcomeList
    {
        public string DisplayMenu()
        {
            List<string> welcome = new List<string>(); // List that hold ASCII things for option screen at the start of the program
            // Adds items to list
            welcome.Add(@"

._____.............................._____............_................._..._..................___..___..........................................................
|.._..|............................|.._..|..........|.|...............|.|.(_).................|..\/..|..........................................................
|.|.|.|_..._..___._..._..___.......|.|.|.|_.__...___|.|_.___._.__.__._|.|_._..___.._.__.......|......|.___._.__.._..._..........................................
|.|.|.|.|.|.|/._.\.|.|.|/._.\......|.|.|.|.'_.\./._.\.__/._.\.'__/._`.|.__|.|/._.\|.'_.\......|.|\/|.|/._.\.'_.\|.|.|.|.........................................
\.\/'./.|_|.|..__/.|_|.|..__/......\.\_/./.|_).|..__/.||..__/.|.|.(_|.|.|_|.|.(_).|.|.|.|.....|.|..|.|..__/.|.|.|.|_|.|.........................................
.\_/\_\\__,_|\___|\__,_|\___|.......\___/|..__/.\___|\__\___|_|..\__,_|\__|_|\___/|_|.|_|.....\_|..|_/\___|_|.|_|\__,_|.........................................
.........................................|.|....................................................................................................................
.........................................|_|....................................................................................................................
" + "\n\n");

            welcome.Add(@"
 __       ___      _     _   _____ _                 
/  | _   / _ \    | |   | | |_   _| |                
`| |(_) / /_\ \ __| | __| |   | | | |_ ___ _ __ ___  
 | |    |  _  |/ _` |/ _` |   | | | __/ _ \ '_ ` _ \ 
_| |__  | | | | (_| | (_| |  _| |_| ||  __/ | | | | |
\___(_) \_| |_/\__,_|\__,_|  \___/ \__\___|_| |_| |_|
                                                 
");
            welcome.Add(@"
 _____     ______     _      _      _____ _                     
/ __  \ _  |  _  \   | |    | |    |_   _| |                    
`' / /'(_) | | | |___| | ___| |_ ___ | | | |_ ___ _ __ ___  ___ 
  / /      | | | / _ \ |/ _ \ __/ _ \| | | __/ _ \ '_ ` _ \/ __|
./ /___ _  | |/ /  __/ |  __/ ||  __/| |_| ||  __/ | | | | \__ \
\_____/(_) |___/ \___|_|\___|\__\___\___/ \__\___|_| |_| |_|___/      

");
            welcome.Add(@"
 _____     _____ _                                           _                        __   _ _                     
|____ |_  /  ___| |                                         | |                      / _| (_) |                    
    / (_) \ `--.| |__   _____      __  _ __  _   _ _ __ ___ | |__   ___ _ __    ___ | |_   _| |_ ___ _ __ ___  ___ 
    \ \    `--. \ '_ \ / _ \ \ /\ / / | '_ \| | | | '_ ` _ \| '_ \ / _ \ '__|  / _ \|  _| | | __/ _ \ '_ ` _ \/ __|
.___/ /_  /\__/ / | | | (_) \ V  V /  | | | | |_| | | | | | | |_) |  __/ |    | (_) | |   | | ||  __/ | | | | \__ \
\____/(_) \____/|_| |_|\___/ \_/\_/   |_| |_|\__,_|_| |_| |_|_.__/ \___|_|     \___/|_|   |_|\__\___|_| |_| |_|___/    

");
            welcome.Add(@"

   ___    ______ _           _    ___          _____ _                             
  /   |_  |  ___(_)         | |  / _ \        |_   _| |                            
 / /| (_) | |_   _ _ __   __| | / /_\ \_ __     | | | |_ ___ _ __ ___              
/ /_| |   |  _| | | '_ \ / _` | |  _  | '_ \    | | | __/ _ \ '_ ` _ \             
\___  |_  | |   | | | | | (_| | | | | | | | |  _| |_| ||  __/ | | | | |            
    |_(_) \_|   |_|_| |_|\__,_| \_| |_/_| |_|  \___/ \__\___|_| |_| |_|            
                                                                           
");
            welcome.Add(@"
 _____    ______     _       _      ___  _ _   _____ _                            
|  ___|_  | ___ \   (_)     | |    / _ \| | | |_   _| |                           
|___ \(_) | |_/ / __ _ _ __ | |_  / /_\ \ | |   | | | |_ ___ _ __ ___  ___        
    \ \   |  __/ '__| | '_ \| __| |  _  | | |   | | | __/ _ \ '_ ` _ \/ __|       
/\__/ /_  | |  | |  | | | | | |_  | | | | | |  _| |_| ||  __/ | | | | \__ \       
\____/(_) \_|  |_|  |_|_| |_|\__| \_| |_/_|_|  \___/ \__\___|_| |_| |_|___/       

");
            welcome.Add(@"
  ____     _____     _ _      
 / ___|_  |  ___|   (_) |     
/ /___(_) | |____  ___| |_    
| ___ \   |  __\ \/ / | __|   
| \_/ |_  | |___>  <| | |_    
\_____(_) \____/_/\_\_|\__|   
                              
");
            welcome.Add(@"
 _____      _             __   __                 _____ _           _                                                       
|  ___|    | |            \ \ / /                /  __ \ |         (_)         _                                            
| |__ _ __ | |_ ___ _ __   \ V /___  _   _ _ __  | /  \/ |__   ___  _  ___ ___(_)                                           
|  __| '_ \| __/ _ \ '__|   \ // _ \| | | | '__| | |   | '_ \ / _ \| |/ __/ _ \                                             
| |__| | | | ||  __/ |      | | (_) | |_| | |    | \__/\ | | | (_) | | (_|  __/_                                            
\____/_| |_|\__\___|_|      \_/\___/ \__,_|_|     \____/_| |_|\___/|_|\___\___(_)   ");
            foreach (string s in welcome) // when this method is called, this foreach loop will display each item in this list
            {
                Console.Write(s);
            }
            string str = "";
            return str; // Returns empty string because it was an string method and had to return something
        }
    }
}
