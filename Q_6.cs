using System;


//Program class and Main Method
namespace MovieBookingApp      
{
    public class Program         
    {
        static void Main(string[] args)       
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Movie Ticket Booking Application");
            Console.WriteLine("************************************\n");

            string movie_name = null;
            Console.WriteLine("Dear Viewer, Please enter the movie name you want to watch. \n\n1.Darbar\n2.Bigil\n3.Pattas\n\nEnter your movie tilte :");
            movie_name = Console.ReadLine();
            Console.WriteLine("Please provide movie cast names(cast names separated by coma) : ");
            string cast_Names = Console.ReadLine();

            Console.WriteLine("Please provide ticket price in valid format : ");
            double ticket_Price = Convert.ToDouble(Console.ReadLine());

            Movie selectedMovie = new Movie();
            selectedMovie = CreateMovie(movie_name, cast_Names, ticket_Price);
            selectedMovie.displayDetails();

            static Movie CreateMovie(string movie_name, string cast_Names, double ticket_Price)
            {
                Movie selectedMovie = new Movie();
                selectedMovie.Title = movie_name;
                selectedMovie.cast = cast_Names;
                selectedMovie.TicketPrice = ticket_Price;
                if (movie_name == "")
                {
                    throw new Exception("\n\n******Movie title cannot be empty. Please provide valid value.******\n\n");
                }
                if (cast_Names == "")
                {
                    throw new Exception("\n\n******Movie cast cannot be empty. Please provide valid value.******\n\n");
                }
                if (ticket_Price <= 0)
                {
                    throw new Exception("\n\n******Incorrect value for Movie price. Please provide valid value.******\n\n");
                }

                return selectedMovie;
            }

                       
            string movieAvailabilty = Movie.movieInfo(movie_name);
            Console.WriteLine("\n\nDo you want to buy tickets for this movie? y/n");
            string buyStatus = Console.ReadLine();

            DateTime booking_Date = new DateTime();

            if (movieAvailabilty == "Available")
            {

                if (buyStatus == "y")
                {
                    Console.WriteLine("Please enter the date for which you want to buy the tickets in mm/dd/yyyy format : ");
                    booking_Date = DateTime.Parse(Console.ReadLine());
                    
                    Console.WriteLine("How many tickets do you want?");
                    int ticket_Count = Convert.ToInt32(Console.ReadLine());

                    Ticket ticket_Amount = new();
                    ticket_Amount = BuyTicket(booking_Date, ticket_Count, selectedMovie);

                    static Ticket BuyTicket(DateTime booking_Date, int ticket_Count, Movie selected_Movie)
                    {
                        Ticket ticketAmount = new Ticket();
                        ticketAmount.Movie = selected_Movie;
                        ticketAmount.BookingDate = booking_Date;
                        ticketAmount.TicketCount = ticket_Count;
                        ticketAmount.TotalAmount = ticket_Count * selected_Movie.TicketPrice;
                        if (booking_Date < DateTime.Now)
                        {
                            throw new Exception("\n\n******Incorrect date provided. Please recheck******\n\n");
                        }
                        if (ticket_Count <= 0)
                        {
                            throw new Exception("\n\n******Incorrect value provided for the number of tickets. Please recheck******\n\n");
                        }
                            return ticketAmount;
                    }
                    
                    ticket_Amount.movieDetails();
                }
                else
                {
                    Console.WriteLine("\n\n***Thank you for choosing us.***");
                }
            }
            else if (movieAvailabilty == "Not Available")
            {
                Console.WriteLine("\n\n***The movie isn't available rightnow. \nCome back again.\nThank you for choosing us.***");
            }
        }
    }
}


//Movie Class
namespace MovieBookingApp
{
    public class Movie
    {
        public int Id;
        public string Title;
        public string cast;
        public double TicketPrice;

        public static string movieInfo(string Title)
        {
            string movieAvailabilty = null;
            if (Title == "Darbar")
            {
                movieAvailabilty = "Available";
            }
            else if (Title == "Bigil")
            {
                movieAvailabilty = "Available";
            }
            else if (Title == "Pattas")
            {
                movieAvailabilty = "Not Available";
            }
            return movieAvailabilty;
        }
        public void displayDetails()
        {
            Console.WriteLine($"\n\nDear viewer, you have choosen to watch {Title}.\n\nMovie name : {Title}\nCast : {cast}\nTicket Price : {TicketPrice}");
        }
    }
}

//Ticket class
namespace MovieBookingApp
{
    public class Ticket
    {
        public Movie Movie;
        public DateTime BookingDate;
        public int TicketCount;
        public double TotalAmount;


        public void movieDetails()
        {
            Console.WriteLine($"\n\nDear viewer, your movie details are as follows:\n\nMovie :{Movie.Title} \nBooking date : {BookingDate}\nNo. of tickets : {TicketCount}\nTotal amount : {TotalAmount}");
            Console.WriteLine("\n\n***Thank you. Enjoy your movie. Have a great day***");
        }
    }
}

