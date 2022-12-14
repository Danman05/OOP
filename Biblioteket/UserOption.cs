using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class UserOption
    {
        /// <summary>
        /// Option list for user
        /// </summary>
        public void DisplayOption()
        {
            List<string> options = new List<string>();

            options.Add(@"
                                                                                                                        
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|                                                                                                                                                                                                                                    
");
            options.Add(@"
 _     _ _                                                       
| |   (_) |                                                      
| |    _| |__  _ __ __ _ _ __ _   _   _ __ ___   ___ _ __  _   _ 
| |   | | '_ \| '__/ _` | '__| | | | | '_ ` _ \ / _ \ '_ \| | | |
| |___| | |_) | | | (_| | |  | |_| | | | | | | |  __/ | | | |_| |
\_____/_|_.__/|_|  \__,_|_|   \__, | |_| |_| |_|\___|_| |_|\__,_|
                               __/ |                             
                              |___/                              
");
            options.Add(@"
                                                                                                                        
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|                                                                                                                                                                                                                                    
");
            options.Add(@"
 __     ______ _           _                ___  _ _   _                 _        
/  |    |  _  (_)         | |              / _ \| | | | |               | |       
`| |    | | | |_ ___ _ __ | | __ _ _   _  / /_\ \ | | | |__   ___   ___ | | _____ 
 | |    | | | | / __| '_ \| |/ _` | | | | |  _  | | | | '_ \ / _ \ / _ \| |/ / __|
_| |__  | |/ /| \__ \ |_) | | (_| | |_| | | | | | | | | |_) | (_) | (_) |   <\__ \
\___(_) |___/ |_|___/ .__/|_|\__,_|\__, | \_| |_/_|_| |_.__/ \___/ \___/|_|\_\___/
                    | |             __/ |                                         
                    |_|            |___/                                          ");
            options.Add(@"
 _____    ______             _      _                       
/ __  \   | ___ \           | |    | |                      
`' / /'   | |_/ / ___   ___ | | __ | |     ___   __ _ _ __  
  / /     | ___ \/ _ \ / _ \| |/ / | |    / _ \ / _` | '_ \ 
./ /____  | |_/ / (_) | (_) |   <  | |___| (_) | (_| | | | |
\_____(_) \____/ \___/ \___/|_|\_\ \_____/\___/ \__,_|_| |_|
                                                            
                                                            ");
            options.Add(@"
 _____    _   _ _                 _                 _      _                       
|____ |  | | | (_)               | |               | |    | |                      
    / /  | | | |_  _____      __ | |__   ___   ___ | | __ | | ___   __ _ _ __  ___ 
    \ \  | | | | |/ _ \ \ /\ / / | '_ \ / _ \ / _ \| |/ / | |/ _ \ / _` | '_ \/ __|
.___/ /  \ \_/ / |  __/\ V  V /  | |_) | (_) | (_) |   <  | | (_) | (_| | | | \__ \
\____(_)  \___/|_|\___| \_/\_/   |_.__/ \___/ \___/|_|\_\ |_|\___/ \__,_|_| |_|___/
                                                                                   
                                                                                   ");
            options.Add(@"
   ___     _____     _ _   
  /   |   |  ___|   (_) |  
 / /| |   | |____  ___| |_ 
/ /_| |   |  __\ \/ / | __|
\___  |_  | |___>  <| | |_ 
    |_(_) \____/_/\_\_|\__|
                           
                           ");

            foreach (string i in options)
            {
                Console.WriteLine(i);
            }
        }

    }
}
