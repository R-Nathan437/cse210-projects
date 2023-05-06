// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Board _board = new Board();


_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us...",
        new Source("2 Timothy 1:7")
        )
    );
_board.AddQuote(
    new Quote(
        "Sister Elaine",
        "Work hard to acheive..",
        new Source("How to Dare Great Things, https://www.churchofjesuschrist.org")

    )
);

_board.AddQuote(new Quote("Alma","If ye have faith ye...", new Source("Alma 32:21")));
_board.AddQuote(new Quote("Alma", "Live in thanksgving...", new Source("Alma 34:38")));
_board.AddQuote(new Quote("Alma","Counsel with the Lord...", new Source("Alma 37:37")));

Menu _menu = new Menu(_board);
_menu.Display();