using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using ProjectEnums;

namespace ProjectTables
{
    public abstract class Employee
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "ID Documnet Type Field Is Required")]
        [Display(Name = "ID Documnet Type")]
        public IDType IDType { get; set; }


        [Required(ErrorMessage = "ID Number Field Is Required")]
        [Display(Name = "ID Number")]
        public string IDNumber { get; set; }


        [Required(ErrorMessage = "Fisrt Name Field Is Required")]
        [Display(Name = "First Name")]
        [MaxLength(15, ErrorMessage = "First Name can't be more then 15 characters..."),
         MinLength(2, ErrorMessage = "First Name can't be less then 2 characters...")]
        public string FirstName { get; set; }


        [Display(Name = "Middle Name")]
        [MaxLength(15, ErrorMessage = "Middle Name can't be more then 15 characters..."),
         MinLength(2, ErrorMessage = "Middle Name can't be less then 2 characters...")]
        public string MiddleName { get; set; }


        [Required(ErrorMessage = "Last Name Field Is Required")]
        [Display(Name = "Last Name")]
        [MaxLength(15, ErrorMessage = "Last Name can't be more then 15 characters..."),
         MinLength(2, ErrorMessage = "Last Name can't be less then 2 characters...")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email Address Field Is Required")]
        [Display(Name = "Personal Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [MaxLength(50, ErrorMessage = "Email can't be more then 50 characters..."),
         MinLength(11, ErrorMessage = "Email can't be less then 11 characters...")]
        [EmailAddress(ErrorMessage = "Example@domain.com")]
        public string PersonalEmail { get; set; }


        [Required(ErrorMessage = "Phone Number Field Is Required")]
        [Phone]
        public string PersonalPhoneNumber { get; set; }


        [Required(ErrorMessage = "Date Of Birth Field Is Required")]
        [Display(Name = "Date OF Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOFBirth { get; set; }


        [Required(ErrorMessage = "Gender Field Is Required")]
        public Gender Gender { get; set; }


        public string Address { get; set; }
        public string Location { get; set; }


        [Required(ErrorMessage = "HealthIssues Field Is Required")]
        [Display(Name = "Health Issues")]
        public bool HealthIssues { get; set; }


        [Required(ErrorMessage = "HealthIssues Field Is Required")]
        [Display(Name = "Socail Status")]
        public SocailStatus SocailStatus { get; set; }


        [Display(Name = "Army Status")]
        public ArmyStatus ArmyStatus { get; set; }
    }
    public abstract class EmployeeOffice
    {
        [Key]
        public Guid EmpID { get; set; }

        [MaxLength(20, ErrorMessage = "Email can't be more then 20 characters...")]
        [MinLength(8, ErrorMessage = "Email can't be less then 8 characters...")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password Field Is Required")]
        [DataType(DataType.Password)]
        [MaxLength(20, ErrorMessage = "Password can't be more then 20 characters...")]
        [MinLength(8, ErrorMessage = "Password can't be less then 8 characters...")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email Address Field Is Required")]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [MaxLength(50, ErrorMessage = "Email can't be more then 50 characters...")]
        [MinLength(11, ErrorMessage = "Email can't be less then 11 characters...")]
        [EmailAddress(ErrorMessage = "more.eg.Example@domain.com, more.sa.Example@domain.com")]
        public string EmailOffice { get; set; }


        [Phone]
        [Display(Name = "Office Ph-Number")]
        public string OfficePhoneNumber { get; set; }
    }
    public abstract class Departement
    {
        [Key]
        public Guid DeptID { get; set; }

        [Required(ErrorMessage = "Departement Name Field Is Requires")]
        [Display(Name = "Departement Name")]
        public string DeptName { get; set; }

        [Display(Name = "Departement Discription")]
        public string DeptDescription { get; set; }
    }
    public abstract class EmployeeAddress
    {
        [Key]
        public int EmployeeAddressID { get; set; }

        public Country Country { get; set; }
        public Country City { get; set; }

        [Display(Name = ("Address"))]
        [MaxLength(100, ErrorMessage = "Address can't be more then 100 characters...")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [DataType(DataType.Url)]
        public string Location { get; set; }
    }
    public abstract class Attending 
    {
        [Key]
        public int AttendID { get; set; }

        [Required]
        public WeekDays DayName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DayDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime AttendanceTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }

    }
}

namespace ProjectEnums
{
    public enum IDType
    {
        [Display(Name = "Socail Security Number")]
        SSN,
        Passport,
        [Display(Name = "Army Recruiting Card")]
        ArmyCard
    }
    public enum SocailStatus
    {
        Single,
        Divorced,
        Married,
        engaged
    }
    public enum ArmyStatus
    {
        [Display(Name = "Final Exemption")]
        Finalexemption,
        [Display(Name = "Temporary Exemption")]
        Temporaryexemption,
        [Display(Name = "Put Off")]
        Putoff
    }
    public enum Gender
    {
        Male, Female
    }
    public  enum Country
    {
        Afghanistan,
        Albania,
        Algeria,
        Andorra,
        Angola,
        Antigua,  Barbuda,
        Argentina,
        Armenia,
        Australia,
        Austria,
        AustrianEmpire,
        Azerbaijan,

        Baden,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Bavaria,
        Belarus,
        Belgium,
        Belize,
        [Display(Name = "Benin( Dahomey )")]
        Benin,
        Bolivia,
        Bosnia,Herzegovina,
        Botswana,
        Brazil,
        Brunei,
        Brunswick, Lüneburg,
        Bulgaria,
        [Display(Name = "Burkina Faso (Upper Volta)")]
        Burkina,
        Burma,
        Burundi,
        [Display(Name = "Cabo Verde")]
        CaboVerde,
        Cambodia,
        Cameroon,
        Canada,
        [Display(Name = "Cayman Islands")]
        CaymanIslands,
        [Display(Name = "Central African Republic")]
        CentralAfricanRepublic,
        [Display(Name = "Central American Federation")]
        CentralAmericanFederation,
        Chad,
        Chile,
        China,
        Colombia,
        Comoros,
        [Display(Name = "Congo Free State")]
        CongoFreeState,
        [Display(Name = "Costa Rica")]

        CostaRica,
        [Display(Name = "Cote d’Ivoire (Ivory Coast)")]

        CotedIvoire,
        Croatia,
        Cuba,
        Cyprus,
        Czechia,
        Czechoslovakia,
        [Display(Name = "Democratic Republic of the Congo")]

        DemocraticRepublicoftheCongom,
        Denmark,
        Djibouti,
        Dominica,
        [Display(Name = "Dominican Republic")]

        DominicanRepublic,
        [Display(Name = "Duchy of Parma")]

        DuchyofParma,
        [Display(Name = "East Germany (German Democratic Republic)")]
        EastGermany,
        Ecuador,
        Egypt,
        [Display(Name = "El Salvador")]
        ElSalvador,
        [Display(Name = " Equatorial Guinea")]
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Eswatini,
        Ethiopia,
        [Display(Name = "Federal Government of Germany")]
        FederalGovernmentofGermany,
        Finland,
        France,

        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        [Display(Name = "Grand Duchy of Tuscany")]
        GrandDuchyofTuscany,
        Greece,
        Grenada,
        Guatemala,
        Guinea,
        [Display(Name = "Guinea Bissau")]
        GuineaBissau,
        Guyana,
        Haiti,
        Hanover,
        [Display(Name = "Hanseatic Republics")]
        HanseaticRepublics,
        Hawaii,
        Hesse,
        [Display(Name = "Holy See")]
        HolySee,
        Honduras,
        Hungary,

        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        Israel,
        Italy,

        Jamaica,
        Japan,
        Jordan,

        Kazakhstan,
        Kenya,
        [Display(Name = "Kingdom of Serbia/Yugoslavia")]
        KingdomofSerbiaYugoslavia,
        Kiribati,
        Korea,
        Kosovo,
        Kuwait,
        Kyrgyzstan,

        Laos,
        Latvia,
        Lebanon,
        Lesotho,
        [Display(Name = "Lew Chew (Loochoo)")]
        LewChewLoochoo,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxembourg,


        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        [Display(Name = "Marshall Islands")]
        MarshallIslands,
        Mauritania,
        Mauritius,
        [Display(Name = "Mecklenburg-Schwerin")]
        MecklenburgSchwerin,
        [Display(Name = "Mecklenburg-Strelitz")]
        MecklenburgStrelitz,
        Mexico,
        Micronesia,
        Moldova,
        Monaco,
        Mongolia,
        Montenegro,
        Morocco,
        Mozambique,

        Namibia,
        Nassau,
        Nauru,
        Nepal,
        Netherlands,
        [Display(Name = "New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        [Display(Name = "North German Confederation")]
        NorthGermanConfederation,
        [Display(Name = "North German Union")]
        NorthGermanUnion,
        [Display(Name = "North Macedonia")]
        NorthMacedonia,
        Norway,

        Oldenburg,
        Oman,
        [Display(Name = "Orange Free State")]
        OrangeFreeState,

        Pakistan,
        Palau,
        Panama,
        [Display(Name = "Papal States")]
        PapalStates,
        [Display(Name = "Papua New Guinea")]
        PapuaNewGuinea,
        Paraguay,
        Peru,
        Philippines,
        [Display(Name = "Piedmont Sardinia")]
        PiedmontSardinia,
        Poland,
        Portugal,

        Qatar,

        [Display(Name = "Republic of Genoa")]
        RepublicofGenoa,
        [Display(Name = "Republic of Korea (South Korea)")]
        RepublicofKoreaSouthKorea,
        [Display(Name = "Republic of the Congo")]
        RepublicoftheCongo,
        Romania,
        Russia,
        Rwanda,

        [Display(Name = "Saint Kitts and Nevis")]
        SaintKittsandNevis,
        [Display(Name = "Saint Lucia")]
        SaintLucia,
        [Display(Name = "Saint Vincent and the Grenadines")]
        SaintVincentandtheGrenadines,
        Samoa,
        [Display(Name = "San Marino")]
        SanMarino,
        [Display(Name = "Sao Tome and Principe")]
        SaoTomeandPrincipe,
        [Display(Name = "Saudi Arabia")]
        SaudiArabia,
        [Display(Name = "Schaumburg Lippe")]
        SchaumburgLippe,
        Senegal,
        Serbia,
        Seychelles,
        [Display(Name = "Sierra Leone")]
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        [Display(Name = "Solomon Islands")]
        SolomonIslands,
        Somalia,
        [Display(Name = "South Africa")]
        SouthAfrica,
        [Display(Name = "South Sudan")]
        SouthSudan,
        Spain,
        [Display(Name = "Sri Lanka")]
        SriLanka,
        Sudan,
        Suriname,
        Sweden,
        Switzerland,
        Syria,

        Tajikistan,
        Tanzania,
        Texas,
        Thailand,
        [Display(Name = "Timor Leste")]
        TimorLeste,
        Togo,
        Tonga,
        Trinidad, 
        Tobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        Tuvalu,
        [Display(Name = "Two Sicilies")]
        TwoSicilies,

        Uganda,
        Ukraine,
        [Display(Name = "Union of Soviet Socialist Republics")]
        UnionofSovietSocialistRepublics,
        [Display(Name = "United Arab Emirates")]
        UnitedArabEmirates,
        [Display(Name = "United Kingdom")]
        UnitedKingdom,
        Uruguay,
        Uzbekistan,

        Vanuatu,
        Venezuela,
        Vietnam,

        Württemberg,

        Yemen,

        Zambia,
        Zimbabwe
    }
    public  enum WeekDays
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
}

namespace ProjectFiles
{
    public class FileUpload
    {
        [Key]
        public int FileID { get; set; }

        [Required(ErrorMessage = "File Name Field Is Required")]
        [Display(Name ="File Name")]
        public string FileName { get; set; }

        [Display(Name = "File Discription")]
        public string FileDiscription { get; set; }

        public List<IFormFile> formFiles { get; set; }
    }
    public class Finances : FileUpload
    {

    }
    public class Warnings : FileUpload
    {

    }
    public class Contracts : FileUpload
    {

    }
    public class Certificates : FileUpload
    {

    }
    public class Vacations : FileUpload 
    {

    }
    public class Documnets : FileUpload
    {
        /*
         * Army 
         * SSN
         * Passport
         * Birth Certificate
         * Criminal records certificate
         * Gradiuation Certificate
         * CV
         */
    }
    public class OtherDocuments : FileUpload
    {

    }
}