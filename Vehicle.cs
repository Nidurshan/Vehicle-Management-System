namespace Vehicle_Management_System
{
    public class Vehicle
    {
        public string Model {  get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public DateTimeOffset InsuranceExpiryDate { get; set; }
        public DateTimeOffset LicenseExpiryDate { get; set; }
        public DateTimeOffset EmissionExpiryDate { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(
            string model,
            string number,
            string type,
            DateTimeOffset insuranceExpiryDate,
            DateTimeOffset licenseExpiryDate,
            DateTimeOffset emissionExpiryDate)
        {
            Model = model;
            Number = number;
            Type = type;
            InsuranceExpiryDate = insuranceExpiryDate;
            LicenseExpiryDate = licenseExpiryDate;
            EmissionExpiryDate = emissionExpiryDate;
        }

        public string GetType()
        {
            return Type;
        }
    }

    //public enum VehicleType
    //{
    //    Truck,
    //    Van
    //}
}
