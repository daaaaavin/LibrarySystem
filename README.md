# LibrarySystem
Davin and Goody's Amazing Library System for our terrific lecturer Liz Bourke forever may she reign

I'm leaving some notes for your functions but if you have a different idea of how you wanted to go about it it's perfectly fine it's your side of the project so it's whatever you think is best.

Davin:
-Manage Book
-Search By Title/Author/Genre
-Sort by Date/Title/Author
-Export library to data file
-Add Book to Favourites


Goody:
-Set reminders for due books
Note: My advice would just be to have a function so that if a due date is within 3/2/1 days you get a DialogueBox warning that gives you two options "OK" and "Return" and maybe in the case it's not returned a "WARNING: BOOK OVERDUE" with ONLY the "Return Book" option.
-Set books checked out/in
Note: Okay this one's actually kind of important, to show off the checkout/in feature we need a function kinda like the black swan event in our stocks lab, so basically you hit a button and all of the books checked out status aswell as dueDates change, you also need to add a button that let's the user check out a book specifically and maybe add it to a seperate list called in the tab called "Your Books" that displays some info about the book and definitely the due date, then a "return" button 
-Set reminder for checked out book coming into stock
Note: Maybe add a parameter that let's you "wishlist" or "reserve" a book maybe, and if that book comes back into stock it will give another dialogue box and you can choose to check it out
-Generate stats page displaying books rented/overdue warnings/most-read genres and authors
Note: Basically just put counters on all the overdue warnings and the "most-read" stuff is just grabbing the "TimesRead" variable and sorting by genre to figure out which genres are most read
-Set reading goals under a timeframe
Note: I lowkey didn't put any functionality for this one because I forgot it existed but it shouldn't be too tough to add stuff
