using System;
using System.Media;
using static System.Net.WebRequestMethods;
using System.Numerics;

namespace CybersecurityChatbot
{
    class Program
    {
        public static string UserName { get; set; }

        // 30 cybersecurity-related questions
        static string[] Questions = new string[]
        {
            "What is phishing?",
            "How can I identify a phishing email?",
            "What are some common phishing tactics?",
            "How do I avoid phishing scams?",
            "What should I do if I clicked a phishing link?",
            "Are phishing emails always obvious?",
            "What is spear phishing?",
            "Can phishing occur via text messages?",
            "How do companies protect against phishing?",
            "Is phishing only done through email?",
            "What is safe browsing?",
            "How do I stay safe while browsing online?",
            "What are secure websites?",
            "What is HTTPS and why is it important?",
            "How do I avoid malicious ads?",
            "Can browser extensions be dangerous?",
            "What is private/incognito mode?",
            "How do I clear my browsing history?",
            "What is a fake website?",
            "How do I know if a website is fake?",
            "What makes a strong password?",
            "How often should I change my passwords?",
            "What is two-factor authentication?",
            "How do I manage my passwords securely?",
            "Should I use the same password everywhere?",
            "How do I store passwords safely?",
            "Are password managers safe?",
            "What is password cracking?",
            "What should I do if my password is leaked?",
            "How do I protect my accounts online?"
        };

        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            PlayVoiceGreeting();
            DisplayASCIIArt();
            GetUserDetails();
            ChatLoop();
        }

        static void PlayVoiceGreeting()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer("Sounds\\greeting.wav"))
                {
                    player.Load();
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Voice greeting failed to play: {ex.Message}");
                Console.ResetColor();
            }
        }

        static void DisplayASCIIArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
 ..................                                          
                                        .....=***+++*+-....                                         
                                        ....*****=++***+...                                         
                                        ...=*****=++***#+..                                         
                                        ...*##**+++++*#%#:.                                         
                                        ..*#******+++**+%=.                                         
                                     ....=##+#@@@@@@@@%=#%:......                                   
                                     ...-#*%@@@@@@@@@@@@%*#-.....                                   
                                     ...-%@@@@@@@@+-::#@@@*=.....                                   
                                  .......*@@@@@@@@#:..#@@@%-....... ..                              
                                  ......-##@@@@%@@%#:%@@@#%=.....                                   
                                ...-+###=#@@@@@@@@%:@@@@@@#+*##+-.....                              
                             ....:#####**%@@@@@@@@@@@@@@@@%*+####%-....                             
                             ...:#######**#@@%@@@@@@@@@%@#**#######-...                             
                             ...=#*%@*%*###@@+@@@@@@@@##@###*##@%##*...                             
                             ..:####%%%*###@@=@@@@@@@@@=@###*%%%####-.                              
                             ..*####%-:::::::.:::::::::.::::::-%####%..                             
                             ..######..........................*%####:.                             
                             .=####%%..........................%%####+.                             
                             .*####%%..........................%%#####:.....                        
                          .. =%%%@@@@..........................%@@@%%%+.....                        
                          ..=##@%%@@@:.:.........:::...........@@@@%@%#+....                        
                          ..=%#####@@::::::::::::::::::::::::::@@%####%+....                        
                          ...#####***--------------------------***#####.....                        
                             .#%%%%%%==========================#@%#%%#:.....                        
                       ........*%%@#=**************************=*@%%#.......                        
                       .....................................................                        
                             ........ .............................. .                              
                             ........ .............................. .                      

                                         CYBER SENTINEL
                                       [ DEFENSE SYSTEM ]
                                     [==========||=========]

                          Cybersecurity Awareness Bot - Keeping You Safe Online!
            ");
            Console.ResetColor();
        }

        static void GetUserDetails()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPlease enter your name: ");
            Console.ResetColor();

            UserName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(UserName))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Name can't be empty! Please enter your name: ");
                Console.ResetColor();
                UserName = Console.ReadLine();
            }

            Console.WriteLine($"\nWelcome, {UserName}! Feel free to ask me anything about cybersecurity.");
            Console.WriteLine(new string('-', 60));
        }

        static void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    TypingEffect("I didn't quite catch that. Could you try again?");
                    continue;
                }

                if (input.Contains("phishing"))
                    TypingEffect("Phishing is a scam where attackers trick you into giving personal information.");
                else if (input.Contains("identify") && input.Contains("phishing"))
                    TypingEffect("Look for suspicious links, spelling errors, and urgent messages.");
                else if (input.Contains("common") && input.Contains("phishing"))
                    TypingEffect("Fake emails, urgent warnings, and unexpected attachments are common tactics.");
                else if (input.Contains("avoid") && input.Contains("phishing"))
                    TypingEffect("Avoid clicking unknown links and always verify sender identities.");
                else if (input.Contains("clicked") && input.Contains("phishing"))
                    TypingEffect("Disconnect from the internet, scan your system, and change your passwords.");
                else if (input.Contains("obvious") && input.Contains("phishing"))
                    TypingEffect("Not always. Some are very well crafted and mimic real sources.");
                else if (input.Contains("spear phishing"))
                    TypingEffect("Spear phishing targets specific individuals with customized messages.");
                else if (input.Contains("text message"))
                    TypingEffect("Yes, phishing via SMS is called 'smishing'. Be cautious with links.");
                else if (input.Contains("companies") && input.Contains("phishing"))
                    TypingEffect("They use email filters, employee training, and anti-phishing tools.");
                else if (input.Contains("only") && input.Contains("email"))
                    TypingEffect("Nope! Phishing can happen via text, calls, and even social media.");
                else if (input.Contains("safe browsing"))
                    TypingEffect("Use updated browsers, enable pop-up blockers, and avoid sketchy sites.");
                else if (input.Contains("stay safe") && input.Contains("browsing"))
                    TypingEffect("Use antivirus, strong passwords, and don't download unknown files.");
                else if (input.Contains("secure website"))
                    TypingEffect("Secure websites use HTTPS and display a lock symbol in the URL bar.");
                else if (input.Contains("https"))
                    TypingEffect("HTTPS encrypts data between you and the website. Always prefer it.");
                else if (input.Contains("malicious ads"))
                    TypingEffect("Avoid clicking pop-ups or ads from unknown sources.");
                else if (input.Contains("browser extensions"))
                    TypingEffect("Install only from trusted sources. Some can steal your data.");
                else if (input.Contains("private") || input.Contains("incognito"))
                    TypingEffect("These modes don't save your history, but don't make you invisible online.");
                else if (input.Contains("clear") && input.Contains("history"))
                    TypingEffect("Use your browser’s settings to clear browsing data regularly.");
                else if (input.Contains("fake website"))
                    TypingEffect("Watch for odd URLs, no HTTPS, and poor design or grammar.");
                else if (input.Contains("know") && input.Contains("fake"))
                    TypingEffect("Hover over links to check URLs and don’t enter info on suspicious pages.");
                else if (input.Contains("strong password"))
                    TypingEffect("Use a mix of letters, numbers, symbols, and avoid dictionary words.");
                else if (input.Contains("change") && input.Contains("password"))
                    TypingEffect("Change them every 3-6 months or immediately after a breach.");
                else if (input.Contains("two-factor"))
                    TypingEffect("2FA adds a second step like a code from your phone. Use it when possible.");
                else if (input.Contains("manage") && input.Contains("password"))
                    TypingEffect("Use a reputable password manager to store and create secure passwords.");
                else if (input.Contains("same") && input.Contains("password"))
                    TypingEffect("Avoid it! If one site is breached, all your accounts are at risk.");
                else if (input.Contains("store") && input.Contains("password"))
                    TypingEffect("Don’t write them down. Use encrypted tools like password managers.");
                else if (input.Contains("password manager"))
                    TypingEffect("Yes, good ones are safe and recommended by security experts.");
                else if (input.Contains("cracking"))
                    TypingEffect("Password cracking is trying to guess your password. Use complex ones.");
                else if (input.Contains("password is leaked"))
                    TypingEffect("Change it immediately and check if other accounts used the same one.");
                else if (input.Contains("protect") && input.Contains("accounts"))
                    TypingEffect("Use strong passwords, 2FA, and monitor for suspicious activity.");
                else if (input.Contains("what can i ask"))
                {
                    TypingEffect("Here are some things you can ask me:");
                    foreach (var question in Questions)
                    {
                        Console.WriteLine($"- {question}");
                        System.Threading.Thread.Sleep(40);
                    }
                }
                else if (input.Contains("exit"))
                {
                    TypingEffect($"Goodbye, {UserName}! Stay safe online.");
                    break;
                }
                else
                    TypingEffect("I'm not sure I understood. Try asking about phishing, passwords, or safe browsing.");
            }
        }

        static void TypingEffect(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(30);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
//GeeksforGeeks, 2024. Creating Strong Passwords. [online] Available at: https://www.geeksforgeeks.org/create-strong-passwords/ [Accessed 23 Apr. 2025].
//GeeksforGeeks, 2024. Email Security Best Practices. [online] Available at: https://www.geeksforgeeks.org/email-security-best-practices/ [Accessed 23 Apr. 2025].
//Norton, 2025.What is Phishing?. [online] Available at: https://us.norton.com/blog/emerging-threats/what-is-phishing [Accessed 23 Apr. 2025].
//Google Safety Center, 2025. Tips for Safe Browsing. [online] Available at: https://safety.google/ [Accessed 23 Apr. 2025].
//National Cyber Security Centre(NCSC), 2024.Two - Factor Authentication(2FA). [online] Available at: https://www.ncsc.gov.uk/guidance/setting-two-factor-authentication-2fa [Accessed 23 Apr. 2025].
//GeeksforGeeks, 2025.What is Malware and Ransomware?. [online] Available at: https://www.geeksforgeeks.org/what-is-malware/ [Accessed 23 Apr. 2025].
//Kaspersky, 2025.What is a VPN ?. [online] Available at: https://www.kaspersky.com/resource-center/definitions/what-is-a-vpn [Accessed 23 Apr. 2025].
///GeeksforGeeks, 2025.How to Identify a Secure Website. [online] Available at: https://www.geeksforgeeks.org/how-to-identify-a-secure-website/ [Accessed 23 Apr. 2025].
//IBM, 2024.What is Social Engineering ?. [online] Available at: https://www.ibm.com/topics/social-engineering [Accessed 23 Apr. 2025].
//Norton, 2025.What is Spyware?. [online] Available at: https://us.norton.com/blog/malware/spyware [Accessed 23 Apr. 2025].
//Federal Trade Commission(FTC), 2025.What to Know About Identity Theft. [online] Available at: https://www.identitytheft.gov/ [Accessed 23 Apr. 2025].
//Cloudflare, 2025.What is Encryption?. [online] Available at: https://www.cloudflare.com/learning/ssl/what-is-encryption/ [Accessed 23 Apr. 2025].
//Cybersecurity & Infrastructure Security Agency(CISA), 2025.Cybersecurity Tips. [online] Available at: https://www.cisa.gov/cybersecurity-awareness-program [Accessed 23 Apr. 2025].