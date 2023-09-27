namespace Transportation.Transport
{
    public class Driver
    {
        public string _name;
        public LicenseCategorys LicenseCategory { get; set; }
        public Driver(string name, LicenseCategorys licenseCategory)
        {
            _name = name;
            LicenseCategory = licenseCategory;
        }
        public enum LicenseCategorys
        {
            A1,
            B,
            D
        }
        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
