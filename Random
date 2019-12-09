
        private void personGen(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Random r = new Random();
                Thread.Sleep(1);
                person temp = new person();
                temp.Name = stringGen(4);
                Thread.Sleep(1);
                temp.City = stringGen(4);
                Thread.Sleep(1);
                temp.Age = stringGen(4);
                Thread.Sleep(1);
                temp.Uni = stringGen(4);
                personStore.Add(temp);
            }
        }
        private string stringGen(int len)
        {
            string temp = "";
            Random r = new Random();
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                    temp = temp + (char)r.Next('A', 'E');
                else
                    temp = temp + (char)r.Next('a', 'e');
            }
            return temp;
        }