using System;

namespace programmers
{
    public class ProgrammerFirstLevel
    {
        protected string surname
        {
            get;
        }

        protected int programs_count
        {
            get;
            set;
        }

        protected int programming_languages_count
        {
            get;
            set;
        }

        virtual public int calculate_quality()
        {
            return programs_count * programming_languages_count;
        }

        public override string ToString()
        {
            return String.Format("Фамилия: {0}\nКоличество программ: {1}\n Количество языков: {2}\n Качество: {3}",
                surname,programs_count,programming_languages_count,calculate_quality());
        }

        public ProgrammerFirstLevel(string surname,int programs_count,int programming_languages_count)
        {
            this.surname = surname;
            this.programs_count = programs_count;
            this.programming_languages_count = programming_languages_count;
        }
    }

    public class ProgrammerSecondLevel : ProgrammerFirstLevel
    {
        protected int correct_programs
        {
            get;
            set;
        }

        public override int calculate_quality()
        {
            return base.calculate_quality()*correct_programs/programs_count;
        }

        public override string ToString()
        {
            return String.Format("Фамилия: {0}\nКоличество программ: {1}\nКоличество языков: {2}\nКоличество правильных программ: {3}\nКачество: {4}",
                surname, programs_count, programming_languages_count,correct_programs, calculate_quality());
        }

        public ProgrammerSecondLevel(string surname,int programs_count,int programming_languages_count,int correct_programs) : base(surname, programs_count, programming_languages_count)
        {
            this.correct_programs = correct_programs;
        }
    }

}
