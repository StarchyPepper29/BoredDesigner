Aight welcome to Bored Designer people. My child if you may, the one ill overwork for my own personal gains aka designing and illustrating
(I have personal agendas behind everything)

What is this?

Well this is a Saas which will give you a alluring button which once inevitably pressed will randomize
* Primary Font (from google fonts API)
* Secondary Font (same place)
* Color Pallete of 5 colors (generated runtime and converted into hex)
* A randomized color map showing the screen space/ visual distribution of said colors (css maps from which random ones are dynamically imported)
* Two images to provide a mood (lorem picsum API)
* One image of a random texture (A public dataset of texuture images)
* Aaaand one image of a random shape to help with the shape Language (self made)

You can lock components you like and keep randomizing before youre happy with what you got

User creation auth and ability to save and export boards as well as well (obviously)

Why?
Why not. I need it. There is no such thing I found. Even if there is, I did it too. I draw and design too and some other people do too so your welcome guys.


![image](https://github.com/user-attachments/assets/63aae98e-e61f-4c9c-9d2f-42ba17f07180)



How?
The backend is on ASP .NET the frontend sits in React and SQL for the database. Traditional hehe

Why Bored Designer?
Its a pun. I know it barely lands it's like "Board" Designer but youre bored because you need inspiration.. For which you will use this.. I will show myself out

Below are the Logs (Not from day one but better late than never)
* Day -n to 1
  * I spent hours trying to set this up with no prior knowledge of .NET.
  * I waltz through a .NET crash course to get a feel of how it looks like with respect to node (far scarier I came to learn)
  * I jumped in head first into the concrete and tried to make something that work migrations and all errors solved :D
  * hello world never felt so rewarding
  * create react app acting moody wth



![image](https://github.com/user-attachments/assets/e70293e7-0f88-4268-a18c-b731787934fc)



all done first route said and im asking gpt to tutor me about everything I need to know
MVC set up
front-end directory not comitting wth
All goofy errors fixed what we have is
  * Generate button randomizes and loads everything
  * Board model and component made which will be made to lock and save soon
  * DASHING Ui design created by yours truly


DAY 2:
* The moodboard model revolted alongside the DBContext and the controller itself and nothing is working now
* Moodboards will have a primary id which I will configure the generation of later that will be the primary key (after hours of docs on how onModelCreation works)
* A demo PUT request isnt working for a moodboard because database is not in sync WHAT! after hours of tweaks i realized it was because I had unknowingly manually made a table with same name as Moodboards with mismatching columsn


DAY 3:
* In an attempt to add front end directory to tracking... I irreversibly deleted it. Never ask GPT for sensitive advice. there goes half the project T-T
* I had made a basic lock button but that matters not anymore. I will work on the API and the sufficient responses and make the front-end at the end making sure its TRACKED AIDJASIDJAISdjaisdj
* 
* I ran newer migrations and edited the model to store each color separately for
      A) Laziness since Json convertion of a list is being hit with a brick you have never seen before
      B) In the long run it will make locking and fetching colors easier. Eh eh EH
(istg this is why nobody loves you SQL databases)
* It works after hours the first api call sees the light of day one small step for man one giant leap for humanity

DAY 4:
* Fixed a very weird issue with SQL server shutting itself down had to poke it awake in SQL server manager and ran migrations
* What migrations you ask? User model and moodboard models changed so that moodboard ID can be saved against user table to fetch and apply API calls on
* API calls you ask? All moodboard CRUD endpoints have been set up and should authorize
* (I will fit in illustrations later)

  DAY 5:
  * Vite app created we shall work with that. There are alot of fancy react apps it was quite an experience to even learn what they all do but damn the hot reload and run time is ridiculously fast
  * Thats all i did
