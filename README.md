# Introduction

DorkHunter is a lightweight Windows Forms application designed to streamline and simplify advanced web searches using Google and other specialized search engines. By leveraging carefully crafted search queries (commonly known as "dorks"), DorkHunter helps users quickly locate specific files, configurations, certificates, and other sensitive information indexed on various websites and platforms.  

<img width="1062" height="689" alt="image" src="https://github.com/user-attachments/assets/8e731500-c292-432d-9571-c1ec6e28c0e8" />


# Features and Functionality
- One-Click Advanced Queries: With over 60 dedicated buttons, each triggers a specific search query targeting different types of information, such as:
- Searching for exposed Amazon S3 buckets, DigitalOcean Spaces, and other cloud storage endpoints.
- Locating configuration files (config, .git/config, .svn/entries).
- Finding backup files and database dumps (.bak, .sql, .mdb).
- Searching across popular code repositories like GitHub, GitLab, and Gist for source code and secrets.
- Discovering CMS and web technology fingerprints via services like WhatCMS and Censys.
- Identifying potential security weaknesses via keyword searches for login pages, exposed credentials, error messages, and vulnerable file types.
- Accessing historical snapshots through the Wayback Machine.
- Querying security research platforms such as Open Bug Bounty and RiskIQ.
- Exploring metadata and certificates related to domains via crt.sh and Censys.
- Integration with Multiple Platforms: Supports direct launching of searches on Google, GitHub, Censys, Shodan, Yandex, Reddit, securityheaders.com, and other specialized sites.

# Use Cases
- Security researchers and penetration testers can use DorkHunter to quickly perform reconnaissance and gather intelligence about a target domain or keyword.
- Developers and system administrators can audit publicly accessible information to ensure sensitive data is not inadvertently exposed.
- Anyone interested in advanced web search techniques can explore the power of dorks without manually crafting complex queries.

# How To Use

**Step 1:** Download file `*.rar` https://github.com/0fbiscuit/DorkHunter/blob/main/DorkHunter/all_in_one_setup.rar.  
**Step 2:** Use https://www.virustotal.com/ to check virus... but **DAMN** no virus in this sh!t, trust me!.  
**Step 3:** Extract and run file `setup.exe` (I use .NET 4 so that I can not merge those files into one `*.exe` file).  
**Step 4:** Open app, enter target domain and click on any buttons in the tool to grab the information.

# IMPORTANT
**1. NO VIRUS:**  
<img width="1321" height="855" alt="image" src="https://github.com/user-attachments/assets/ae20df2d-2c50-4c72-a73b-a5abfff20f69" />  

**2. These files are all important for `setup.exe` file:  **
<img width="637" height="216" alt="image" src="https://github.com/user-attachments/assets/d792c8c5-3886-4ba2-8c96-604021851b2f" />  

**3. SETUP:**  
<img width="1073" height="500" alt="image" src="https://github.com/user-attachments/assets/16d6eb09-bcc1-4f7c-ba77-8fb75bd02461" />  
And setup as usual!

# Credits
- **This Application is developed by me - ([The Quan Dao](https://github.com/0fbiscuit)).**

