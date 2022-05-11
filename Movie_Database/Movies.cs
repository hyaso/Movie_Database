using System;



namespace Movie_Database
{
	class Movie
	{
		public string title;
		public string category1;
		public string category2;

		public Movie(string title, string aCategory1, string aCategory2)
        {
			this.title = title;
			category1 = aCategory1;
			category2 = aCategory2;
        }
	}
}

