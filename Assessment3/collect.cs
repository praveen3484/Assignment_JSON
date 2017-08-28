using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{    
    public class collect
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }    
        public int Age { get; set; }
        public class Address
        {
            public string AddressLine { get; set; }
            public List<Phone> Phones { get; set; }
            public class Phone
            {
                public int Home { get; set; }
                public int Mobile { get; set; }
            }
        }
    }

  

    public class collectDatabase : List<collect>
    {
        public collectDatabase()
        {

            Add(new collect()
            {
                Id = 1,
                Name = "Praveen",
                Email = "Praveen1@email.com",
                Age = 22,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 1" ,
                        Phones = new List<collect.Address.Phone>()
                            {
                         
                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }
                        
                            
                            }
                    }
                    
                }

            });

            Add(new collect()
            {
                Id = 2,
                Name = "Harshit",
                Email = "Harshit2@email.com",
                Age = 23,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no2" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }

            });
            Add(new collect()
            {
                Id = 3,
                Name = "Sandeep",
                Email = "Sandeep3@email.com",
                Age = 24,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 3" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }
            });
            Add(new collect()
            {
                Id = 4,
                Name = "Anshul",
                Email = "Anshul4@email.com",
                Age = 25,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 4" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }
            });
            Add(new collect()
            {
                Id = 5,
                Name = "Himani",
                Email = "Himani5@email.com",
                Age = 26,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 5" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }
            });
            Add(new collect()
            {
                Id = 6,
                Name = "Mayank",
                Email = "Mayank@email.com6",
                Age = 22,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 6" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }
            });

            Add(new collect()
            {
                Id = 7,
                Name = "Shubham",
                Email = "Shubham7@email.com",
                Age = 25,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 7" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }
            });

            Add(new collect()
            {
                Id = 8,
                Name = "Aman",
                Email = "Aman@email.com",
                Age = 24,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 8" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }
            });

            Add(new collect()
            {
                Id = 9,
                Name = "Gaurav",
                Email = "Gaurav9@email.com",
                Age = 24,
                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 9" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }
            });

            Add(new collect()
            {
                Id = 10,
                Name = "Manisha",
                Email = "Manisha10@email.com",
                Age = 23,

                Addresses = new List<collect.Address>()
                {   new collect.Address()
                    {
                        AddressLine ="Street no 10" ,
                        Phones = new List<collect.Address.Phone>()
                            {

                                new collect.Address.Phone()
                                {
                                    Home = 12578678,
                                    Mobile=23476486
                                }


                            }
                    }

                }
            });
        }
    }
}
