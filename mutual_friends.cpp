using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutual_frnds
{
    class person
    {
        private string name;
        private string city;
        private string uni;
        private string age;
        private bool isfriend;
        private List<person> friends;
        private List<person> suguestions;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Uni
        {
            get
            {
                return uni;
            }

            set
            {
                uni = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public bool Isfriend
        {
            get
            {
                return isfriend;
            }

            set
            {
                isfriend = value;
            }
        }

        internal List<person> Friends
        {
            get
            {
                return friends;
            }

            set
            {
                friends = value;
            }
        }

        internal List<person> Suguestions
        {
            get
            {
                return suguestions;
            }

            set
            {
                suguestions = value;
            }
        }
    }
}
