
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {

        /// <summary>
        /// Gives the library database some initial data to work/test with
        /// Contains 4 different books, 3 different authors, 2 members
        /// 2 loans wheras 1 is late, 4 copies where 2 are of the same book
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(LibraryContext context)
        {
            LibraryContext db = new LibraryContext();
            base.Seed(context);


            //AUTHORS
            Author davidEvans = new Author()
            {
                Name = "David Evans"
            };

            Author chadOrzel = new Author()
            {
                Name = "Chad Orzel"
            };

            Author gillesDeRais = new Author()
            {
                Name = "Gilles de Rais"
            };

            context.Authors.Add(davidEvans);
            context.Authors.Add(chadOrzel);
            context.Authors.Add(gillesDeRais);

            //BOOKS
            Book doesGodSpeakCat = new Book()
            {
                Title = "Does God Ever Speak through Cats?",
                Author = davidEvans,
                ISBN = 9780929422039,
                Description = "Does God Ever Speak through Cats? is a book about Christian spirituality and cats. When David Evans moved into a new house in Los Angeles, he unwittingly embarked on two strange new journeys. One involved a totally new relationship with God. The other was focused on a stray cat that was living in the backyard. To David's great surprise, he discovered that these two very different journeys were related to each other and had a lot in common. This is the book he wrote to tell that story."
            };

            Book teachYourDogQuantumPhysics = new Book()
            {
                Title = "How to Teach Quantum Physics to Your Dog",
                Author = chadOrzel,
                ISBN = 9781416572299,
                Description = "When physics professor Chad Orzel went to the pound to adopt a dog, he never imagined Emmy. She wasn’t just a friendly mutt who needed a home. Soon she was trying to use the strange ideas of quantum mechanics for the really important things in her life: chasing critters, getting treats, and going for walks. She peppered Chad with questions: Could she use quantum tunneling to get through the neighbor’s fence and chase bunnies? What about quantum teleportation to catch squirrels before they climb out of reach? Where are all the universes in which Chad drops steak on the floor?"
            };

            Book teachYourDogRelativity = new Book()
            {
                Title = "How to Teach Relativity to Your Dog",
                Author = chadOrzel,
                ISBN = 9780465023318,
                Description = "Physics professor Chad Orzel and his inquisitive canine companion, Emmy, tackle the concepts of general relativity in this irresistible introduction to Einstein’s physics. Through armchair—and sometimes passenger-seat—conversations with Emmy about the relative speeds of dog and cat motion or the logistics of squirrel-chasing, Orzel translates complex Einsteinian ideas—the slowing of time for a moving observer, the shrinking of moving objects, the effects of gravity on light and time, black holes, the Big Bang, and of course, E=mc2—into examples simple enough for a dog to understand."
            };

            Book concubinageToSatan = new Book()
            {
                Title = "Concubinage to Satan",
                Author = gillesDeRais,
                ISBN = 9786543205,
                Description = "We were totally disappointed that this book doesn't exist for real, it would have been awesome."
            };

            context.Books.Add(doesGodSpeakCat);
            context.Books.Add(teachYourDogQuantumPhysics);
            context.Books.Add(teachYourDogRelativity);
            context.Books.Add(concubinageToSatan);


            ///BOOK COPIES
            BookCopy copy1 = new BookCopy()
            {
                boken = teachYourDogRelativity
            };


            BookCopy copy2 = new BookCopy()
            {
                boken = teachYourDogRelativity
            };

            BookCopy copy3 = new BookCopy()

            {
                boken = doesGodSpeakCat
            };

            BookCopy copy4 = new BookCopy()
            {
                boken = concubinageToSatan
            };

            context.Copy.Add(copy1);
            context.Copy.Add(copy2);
            context.Copy.Add(copy3);
            context.Copy.Add(copy4);

            //MEMBERS
            Member LasseLarsson = new Member()
            {
                Name = "Lasse Larsson",
                personalID = 4545235723
            };

            Member BellatrixLestrange = new Member()
            {
                Name = "Bellatrix Lestrange",
                personalID = 2345678912
            };
            context.Members.Add(LasseLarsson);
            context.Members.Add(BellatrixLestrange);



            ///LOANS
            Loan lasse1 = new Loan()
            {
                TimeOfLoan = DateTime.Today,
                DueDate = DateTime.Today.AddDays(15),
                aCopy = copy2,
                aMember = LasseLarsson

            };

            //This is a loan object that is initially created as late.
            DateTime loantime = new DateTime(2016, 10, 31, 0, 0, 0, 0);
            DateTime due = new DateTime(2016, 11, 03, 0, 0, 0, 0);
            Loan lasse2 = new Loan()
            { 
                
                TimeOfLoan = loantime,
                DueDate = due,
                aCopy = copy3,
                aMember = LasseLarsson
            };
            context.Loans.Add(lasse1);
            context.Loans.Add(lasse2);

            
            // Persist changes to the database
            context.SaveChanges();
        }
    }
}