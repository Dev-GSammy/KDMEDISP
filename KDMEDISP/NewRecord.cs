namespace KDMEDISP
{
    class NewRecord
    {
        public string BinNo { get; set; }
        public string BinLocation { get; set; }
        public string Ddate { get; set; }
        public string BinType { get; set; }
        public string WasteType { get; set; }
        public string JobType { get; set; }
        public string recDate { get; set; }
        public string Deadline { get; set; }
        public string CustomerName { get; set; }
        public string DriverName { get; set; }
        public string VehicleNo { get; set; }
        public string DeliveryOrderNo { get; set; }

        public NewRecord(string RBinNo, string RBinLoc, string RBinDate,
            string RBintype, string RwasteType, string RJobType, string RRecDate,
            string RDeadline, string custName, string driverName, string vehicleNo, string DeliveryOrderNo)
        {
            this.BinNo = RBinNo;
            this.BinLocation = RBinLoc;
            this.Ddate = RBinDate;
            this.BinType = RBintype;
            this.WasteType = RwasteType;
            this.JobType = RJobType;
            this.recDate = RRecDate;
            this.CustomerName = custName;
            this.DriverName = driverName;
            this.VehicleNo = vehicleNo;
            this.Deadline = RDeadline;
            this.DeliveryOrderNo = DeliveryOrderNo;
        }
    }
}
