using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personeel.Shared
{
    public class Employee
    {
        #region Variables & Properties

        public string LastName { get; set; }

        public string FirstName { get; set; }

        private char _sex;

		public char Sex
		{
			get { return _sex; }
			set { _sex = value; }
		}

		private int _score;

		public int Score
		{
			get { return _score; }
			set 
			{ 
				_score = value; 
				if(_score > 10)
				{
					_score = 10;
				}
				else if(_score < 0)
				{
					_score = 0;
				}
			}
		}
		
		private int _startYear;

		public int StartYear
		{
			get { return _startYear; }
			set { _startYear = value; }
		}

		public int YearsOfService
		{
			get { return DateTime.Today.Year - StartYear; }
		}

        public string SexDescription
        {
            get 
			{
				switch(this.Sex)
				{
					case 'M':
						return "Male";
					case 'F':
						return "Female";
					case 'X':
						return "Other";
					default:
						return "Unknown";
				}
			}
        }

		public decimal Bonus
		{
			get
			{
				return CalculateBonus();
			}
		}
        #endregion

        #region Constructors

        public Employee()
        {
            
        }

        public Employee(string lastName, string firstName, char sex, int score, int startYear)
        {
            
        }

        #endregion

        #region Methods & Functions

        private decimal CalculateBonus()
		{
			decimal basis = 500 + (this.YearsOfService * 20);

			if(this.Score < 5)
			{
				return basis / 2M;
			}
			else if(this.Score >= 7 && this.Score <= 8)
			{
				return basis * 1.5M;
			}
			else if(this.Score >= 9)
			{
				return basis * 2M;
			}
			else
			{
				return basis;
			}
		}

		public void IncreaseScore()
		{
			this.Score++;
		}

		public void DecreaseScore()
		{
			this.Score--;
		}

		public string ShowSummary()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Personeelslid: {this.FirstName} {this.LastName}");
			sb.AppendLine();
			sb.AppendLine($"Geslacht:    {this.SexDescription}");
			sb.AppendLine($"Dienstjaren: {this.YearsOfService}");
			sb.AppendLine($"Beoordeling: {this.Score}");
			sb.AppendLine($"Premie:      {this.Bonus}");

			return sb.ToString();
		}

        #endregion
    }
}
