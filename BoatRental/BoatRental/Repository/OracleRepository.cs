using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Types;
using Oracle.ManagedDataAccess.Client;
using BoatRental.Exceptions;

namespace BoatRental.Repository
{
    public class OracleRepository : IRepository
    {
        private readonly string connectionstring = "User Id=LP;Password=LP;Data Source=192.168.19.128";

        #region Kind type queries
        public int SetKindName(String name, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE SOORT SET NAAM = :naam WHERE SOORTID = :ID"
                };
                command.Parameters.Add("naam", name);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public int SetKindPaysForLock(bool paysForLock, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE SOORT SET BETAALDSLUISGELD = :betaaldSluisGeld WHERE SOORTID = :ID"
                };
                command.Parameters.Add("betaaldSluisGeld", BoolToInt(paysForLock));
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public int SetKindType(String type, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE SOORT SET TYPE = :type WHERE SOORTID = :ID"
                };
                command.Parameters.Add("type", type);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public List<Kind> GetAllKinds()
        {
            List<Kind> kinds = new List<Kind>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM SOORT"
                };

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["SOORTID"].ToString());
                        string name = reader["NAAM"].ToString();
                        bool paysForLock = StringToBool(reader["BETAALDSLUISGELD"].ToString());
                        string type = reader["TYPE"].ToString();

                        kinds.Add(new Kind(id, name, paysForLock, type));
                    }
                }
            }

            return kinds;
        }

        private Kind GetKind(int ID)
        {
            Kind kind = null;

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM SOORT WHERE SOORTID = :ID"
                };
                command.Parameters.Add("ID", ID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["SOORTID"].ToString());
                        string name = reader["NAAM"].ToString();
                        bool paysForLock = StringToBool(reader["BETAALDSLUISGELD"].ToString());
                        string type = reader["TYPE"].ToString();

                        kind = new Kind(id, name, paysForLock, type);
                    }
                }
            }

            return kind;
        }
        #endregion

        #region Motor type queries
        public int SetMotorName(String name, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE AANDRIJVING SET NAAM = :naam WHERE AANDRIJVINGID = :ID"
                };
                command.Parameters.Add("naam", name);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public int SetMotorTankCapacity(double tankCapacity, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE AANDRIJVING SET TANKINHOUD = :tankinhoud WHERE AANDRIJVINGID = :ID"
                };
                command.Parameters.Add("tankinhoud", tankCapacity);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public int SetMotorPrice(double price, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE AANDRIJVING SET PRIJSPERDAG = :prijsperdag WHERE AANDRIJVINGID = :ID"
                };
                command.Parameters.Add("prijsperdag", price);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public int SetMotorMayTraverseLakes(bool mayTraverseLakes, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE AANDRIJVING SET MAGOPMEREN = :magOpMeren WHERE AANDRIJVINGID = :ID"
                };
                command.Parameters.Add("magOpMeren", BoolToInt(mayTraverseLakes));
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public List<Motor> GetAllMotors()
        {
            List<Motor> motors = new List<Motor>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM AANDRIJVING"
                };

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["AANDRIJVINGID"].ToString());
                        string name = reader["NAAM"].ToString();
                        string tankCapacityTemp = reader["TANKINHOUD"].ToString();
                        double tankCapacity;
                        if (tankCapacityTemp == null)
                        {
                            tankCapacity = -1;
                        }
                        else
                        {
                            tankCapacity = double.Parse(tankCapacityTemp);
                        }
                        double price = double.Parse(reader["PRIJSPERDAG"].ToString());
                        bool mayTraverseLakes = StringToBool(reader["MAGOPMEREN"].ToString());

                        motors.Add(new Motor(id, name, tankCapacity, price, mayTraverseLakes));
                    }
                }
            }

            return motors;
        }

        private Motor GetMotor(int ID)
        {
            Motor motor = null;

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM AANDRIJVING WHERE AANDRIJVINGID = :ID"
                };
                command.Parameters.Add("ID", ID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["AANDRIJVINGID"].ToString());
                        string name = reader["NAAM"].ToString();
                        string tankCapacityTemp = reader["TANKINHOUD"].ToString();
                        double tankCapacity;
                        if (tankCapacityTemp == null || tankCapacityTemp == "")
                        {
                            tankCapacity = -1;
                        }
                        else
                        {
                            tankCapacity = double.Parse(tankCapacityTemp);
                        }
                        double price = double.Parse(reader["PRIJSPERDAG"].ToString());
                        bool mayTraverseLakes = StringToBool(reader["MAGOPMEREN"].ToString());

                        motor = new Motor(id, name, tankCapacity, price, mayTraverseLakes);
                    }
                }
            }

            return motor;
        }
        #endregion

        #region Boat type queries
        public int SetBoatKind(Kind kind, String name)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE BOOT SET SOORTID = :ID WHERE NAAM = :naam"
                };
                command.Parameters.Add("ID", kind.ID);
                command.Parameters.Add("naam", name);

                return command.ExecuteNonQuery();
            }
        }

        public int SetBoatMotor(Motor motor, String name)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE BOOT SET AANDRIJVING = :ID WHERE NAAM = :naam"
                };
                command.Parameters.Add("ID", motor.ID);
                command.Parameters.Add("naam", name);

                return command.ExecuteNonQuery();
            }
        }

        public List<Boat> GetAllBoats()
        {
            List<Boat> boats = new List<Boat>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM BOOT"
                };

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["NAAM"].ToString();
                        Kind kind = GetKind(int.Parse(reader["SOORTID"].ToString()));
                        Motor motor = GetMotor(int.Parse(reader["AANDRIJVINGID"].ToString()));

                        boats.Add(new Boat(name, kind, motor));
                    }
                }
            }

            return boats;
        }

        public Boat GetBoat(String nameIn)
        {
            Boat boat = null;

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM BOOT WHERE NAAM = :naam"
                };
                command.Parameters.Add("naam", nameIn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["NAAM"].ToString();
                        Kind kind = GetKind(int.Parse(reader["SOORTID"].ToString()));
                        Motor motor = GetMotor(int.Parse(reader["AANDRIJVINGID"].ToString()));

                        boat = new Boat(name, kind, motor);
                    }
                }
            }

            return boat;
        }
        #endregion

        #region Item type queries
        public int SetItemName(String name, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE ARTIKEL SET NAAM = :naam WHERE ARTIKELID = :ID"
                };
                command.Parameters.Add("naam", name);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public int SetItemPrice(double price, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE ARTIKEL SET PRIJSPERDAG = :prijsPerDag WHERE ARTIKELID = :ID"
                };
                command.Parameters.Add("prijsPerDag", price);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM ARTIKEL"
                };

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["ARTIKELID"].ToString());
                        string name = reader["NAAM"].ToString();
                        double price = double.Parse(reader["PRIJSPERDAG"].ToString());

                        items.Add(new Item(id, name, price));
                    }
                }
            }

            return items;
        }

        private Item GetItem(int ID)
        {
            Item item = null;

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM ARTIKEL WHERE ARTIKELID = :ID"
                };
                command.Parameters.Add("ID", ID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["ARTIKELID"].ToString());
                        string name = reader["NAAM"].ToString();
                        double price = double.Parse(reader["PRIJSPERDAG"].ToString());

                        item = new Item(id, name, price);
                    }
                }
            }

            return item;
        }
        #endregion

        #region Lake type queries
        public int SetLakeName(String name, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE MEER SET NAAM = :naam WHERE MEERID = :ID"
                };
                command.Parameters.Add("naam", name);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public int SetLakePrice(double price, int ID)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE MEER SET PRIJS = :prijs WHERE MEERID = :ID"
                };
                command.Parameters.Add("prijs", price);
                command.Parameters.Add("ID", ID);

                return command.ExecuteNonQuery();
            }
        }

        public List<Lake> GetAllLakes()
        {
            List<Lake> lakes = new List<Lake>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM MEER"
                };

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["MEERID"].ToString());
                        string name = reader["NAAM"].ToString();
                        double price = double.Parse(reader["PRIJS"].ToString());

                        lakes.Add(new Lake(id, name, price));
                    }
                }
            }

            return lakes;
        }

        private Lake GetLake(int ID)
        {
            Lake lake = null;

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM MEER WHERE MEERID = :ID"
                };
                command.Parameters.Add("ID", ID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["MEERID"].ToString());
                        string name = reader["NAAM"].ToString();
                        double price = double.Parse(reader["PRIJS"].ToString());

                        lake = new Lake(id, name, price);
                    }
                }
            }

            return lake;
        }
        #endregion

        #region HireContract type queries
        private HireContract GetHireContract(int ID, String hirerEmailaddress)
        {
            HireContract hireContract = null;

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT CONTRACTID, FRIESEMEREN, TO_CHAR(DATUMVANAF, 'yyyy/mm/dd') AS DATUMVANAF, TO_CHAR(DATUMTOT, 'yyyy/mm/dd')AS DATUMTOT FROM HUURCONTRACT WHERE CONTRACTID = :ID"
                };
                command.Parameters.Add("ID", ID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["CONTRACTID"].ToString());
                        List<Boat> boats = GetHireContractBoats(id);
                        int friescheLakes = int.Parse(reader["FRIESEMEREN"].ToString());
                        DateTime dateStart = DateTime.ParseExact(reader["DATUMVANAF"].ToString(), "yyyy/MM/dd", CultureInfo.InvariantCulture);
                        DateTime dateEnd = DateTime.ParseExact(reader["DATUMTOT"].ToString(), "yyyy/MM/dd", CultureInfo.InvariantCulture);
                        List<Lake> lakes = GetHireContractLakes(id);
                        List<Item> items = GetHireContractItems(id);

                        hireContract = new HireContract(id, hirerEmailaddress, boats, friescheLakes, dateStart, dateEnd, items, lakes);
                    }
                }
            }

            return hireContract;
        }

        private List<Boat> GetHireContractBoats(int ID)
        {
            List<Boat> boats = new List<Boat>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT B.* FROM HUURCONTRACT HC JOIN BOOTCONTRACT BC ON HC.CONTRACTID = BC.CONTRACTID " +
                                                        "JOIN BOOT B ON B.NAAM = BC.BOOTNAAM WHERE HC.CONTRACTID = :ID"
                };
                command.Parameters.Add("ID", ID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["NAAM"].ToString();
                        Kind kind = GetKind(int.Parse(reader["SOORTID"].ToString()));
                        Motor motor = GetMotor(int.Parse(reader["AANDRIJVINGID"].ToString()));

                        boats.Add(new Boat(name, kind, motor));
                    }
                }
            }

            return boats;
        }

        private List<Item> GetHireContractItems(int ID)
        {
            List<Item> items = new List<Item>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT A.* FROM HUURCONTRACT HC JOIN ARTIKELCONTRACT AC ON HC.CONTRACTID = AC.CONTRACTID " +
                                                        "JOIN ARTIKEL A ON A.ARTIKELID = AC.ARTIKELID WHERE HC.CONTRACTID = :ID"
                };
                command.Parameters.Add("ID", ID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["ARTIKELID"].ToString());
                        string name = reader["NAAM"].ToString();
                        double price = double.Parse(reader["PRIJSPERDAG"].ToString());

                        items.Add(new Item(id, name, price));
                    }
                }
            }

            return items;
        }

        private List<Lake> GetHireContractLakes(int ID)
        {
            List<Lake> lakes = new List<Lake>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT C.* FROM HUURCONTRACT HC JOIN MEERCONTRACT MC ON HC.CONTRACTID = MC.CONTRACTID " +
                                                        "JOIN MEER C ON C.MEERID = MC.MEERID WHERE HC.CONTRACTID = :ID"
                };
                command.Parameters.Add("ID", ID);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["MEERID"].ToString());
                        string name = reader["NAAM"].ToString();
                        int price = int.Parse(reader["PRIJS"].ToString());

                        lakes.Add(new Lake(id, name, price));
                    }
                }
            }

            return lakes;
        }
        #endregion

        #region User type queries
        public HireContract AddUserHireContract(int friescheLakes, DateTime dateStart, DateTime dateEnd, List<Boat> boats, String hirerEmailaddress, List<Item> items = null, List<Lake> lakes = null)
        {
            items = items ?? new List<Item>();
            lakes = lakes ?? new List<Lake>();
            HireContract hireContract = null;

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                // Insert contract
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "INSERT INTO HUURCONTRACT (HUURDER, FRIESEMEREN, DATUMVANAF, DATUMTOT) VALUES(:email, :frieseMeren, :datumVanaf, :datumTot)"
                };
                command.Parameters.Add("email", hirerEmailaddress);
                command.Parameters.Add("frieseMeren", friescheLakes);
                command.Parameters.Add("datumVanaf", dateStart);
                command.Parameters.Add("datumTot", dateEnd);

                command.ExecuteNonQuery();


                // Get auto generated ID
                command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT SEQ_CONTRACTID.CURRVAL AS ID FROM DUAL"
                };

                int hireContractID = -1;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hireContractID = int.Parse(reader["ID"].ToString());
                    }
                }


                // Link contract with actual boat, item and lake
                foreach (Boat boat in boats)
                {
                    command = new OracleCommand
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText =
                            "INSERT INTO BOOTCONTRACT (CONTRACTID, BOOTNAAM) VALUES(:contractID, :bootNaam)"
                    };
                    command.Parameters.Add("contractID", hireContractID);
                    command.Parameters.Add("bootNaam", boat.Name);

                    command.ExecuteNonQuery();
                }
                foreach (Item item in items)
                {
                    command = new OracleCommand
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText =
                            "INSERT INTO ARTIKELCONTRACT (CONTRACTID, ARTIKELID) VALUES(:contractID, :artikelID)"
                    };
                    command.Parameters.Add("contractID", hireContractID);
                    command.Parameters.Add("artikelID", item.ID);

                    command.ExecuteNonQuery();
                }
                foreach (Lake lake in lakes)
                {
                    command = new OracleCommand
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText =
                            "INSERT INTO MEERCONTRACT (CONTRACTID, MEERID) VALUES(:contractID, :meerID)"
                    };
                    command.Parameters.Add("contractID", hireContractID);
                    command.Parameters.Add("meerID", lake.ID);

                    command.ExecuteNonQuery();
                }


                // Create contract oject
                hireContract = new HireContract(hireContractID, hirerEmailaddress, boats, friescheLakes, dateStart, dateEnd, items: items, lakes: lakes);
            }

            return hireContract;
        }

        public User ValidateUser(String emailaddress, String password)
        {
            User user = null;

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                // Get user data
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM GEBRUIKER WHERE LOWER(EMAILADRES) = LOWER(:emailadres) AND WACHTWOORD = :wachtwoord"
                };
                command.Parameters.Add("emailadres", emailaddress);
                command.Parameters.Add("wachtwoord", password);

                string name = null;
                bool isAdmin = false;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader["NAAM"].ToString();
                        isAdmin = StringToBool(reader["ISADMINISTRATOR"].ToString());
                    }
                }

                if (name != null)
                {
                    // Get use contracts
                    command = new OracleCommand
                    {
                        Connection = conn,
                        CommandType = CommandType.Text,
                        CommandText =
                        "SELECT CONTRACTID FROM HUURCONTRACT WHERE HUURDER = :emailadres"
                    };
                    command.Parameters.Add("emailadres", emailaddress);

                    List<HireContract> contracts = new List<HireContract>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            contracts.Add(GetHireContract(int.Parse(reader["CONTRACTID"].ToString()), emailaddress));
                        }
                    }

                    user = new User(emailaddress, name, isAdmin, contracts);
                }
            }

            if(user == null)
            {
                throw new LoginFailedException();
            }

            return user;
        }
        #endregion

        #region CONFIG type queries
        public Dictionary<String, object> GetCONFIG()
        {
            Dictionary<String, object> fields = new Dictionary<String, object>();

            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "SELECT * FROM CONFIG"
                };
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fields["frieschLakePrice"] = reader["FRIESEMERENPRIJS"];
                        fields["frieschLakes"] = reader["FRIESEMEREN"];
                        fields["lockPrice"] = reader["SLUISGELD"];
                        fields["maxFrieschLakes"] = reader["MAXFRIESEMEREN"];
                    }
                }
            }

            return fields;
        }

        public int SetCONFIGFrieschLakePrice(double frieschLakePrice)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE CONFIG SET FRIESEMERENPRIJS = :frieseMerenPrijs"
                };
                command.Parameters.Add("frieseMerenPrijs", frieschLakePrice);

                return command.ExecuteNonQuery();
            }
        }

        public int SetCONFIGFrieschLakes(int frieschLakes)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE CONFIG SET FRIESEMEREN = :frieseMeren"
                };
                command.Parameters.Add("frieseMeren", frieschLakes);

                return command.ExecuteNonQuery();
            }
        }

        public int SetCONFIGLockPrice(double lockPrice)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE CONFIG SET SLUISGELD = :sluisGeld"
                };
                command.Parameters.Add("sluisGeld", lockPrice);

                return command.ExecuteNonQuery();
            }
        }

        public int SetCONFIGMaxFrieschLakes(int maxFrieschLakes)
        {
            var conn = new OracleConnection(this.connectionstring);
            using (conn)
            {
                conn.Open();
                var command = new OracleCommand
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText =
                        "UPDATE CONFIG SET MAXFRIESEMEREN = :maxFrieseMeren"
                };
                command.Parameters.Add("maxFrieseMeren", maxFrieschLakes);

                return command.ExecuteNonQuery();
            }
        }
        #endregion

        private int BoolToInt(bool b)
        {
            if (b)
            {
                return 1;
            }
            return 0;
        }

        private bool IntToBool(int i)
        {
            if (i == 1)
            {
                return true;
            }
            return false;
        }

        private bool StringToBool(String s)
        {
            if (s == "1")
            {
                return true;
            }
            return false;
        }
    }
}
