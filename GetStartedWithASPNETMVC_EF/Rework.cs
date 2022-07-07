namespace GetStartedWithASPNETMVC_EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rework")]
    public partial class Rework
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string QRCode { get; set; }

        [StringLength(50)]
        public string Marking_Code { get; set; }

        [StringLength(50)]
        public string ProductType { get; set; }

        [StringLength(50)]
        public string Offline_Time { get; set; }

        [StringLength(50)]
        public string Online_Time { get; set; }

        [StringLength(50)]
        public string Rework_Status { get; set; }

        [StringLength(50)]
        public string Last_Station { get; set; }

        [StringLength(50)]
        public string Last_Result { get; set; }

        [StringLength(50)]
        public string ST101_Date { get; set; }

        [StringLength(50)]
        public string ST101_Time { get; set; }

        [StringLength(50)]
        public string ST101_Package_Result { get; set; }

        [StringLength(50)]
        public string ST101_Camera_Shield { get; set; }

        [StringLength(50)]
        public string ST101_Shaft_M0102049 { get; set; }

        [StringLength(50)]
        public string ST101_Form_Seal_5026859 { get; set; }

        [StringLength(50)]
        public string ST101_Dowel_Pin_5024532 { get; set; }

        [StringLength(50)]
        public string ST101_Dowel_Pin_5020281 { get; set; }

        [StringLength(50)]
        public string ST101_Control_Plat_5025303 { get; set; }

        [StringLength(50)]
        public string ST101_Flange_M0104918 { get; set; }

        [StringLength(50)]
        public string ST101_Seal_Ring_Below_TestValue { get; set; }

        [StringLength(50)]
        public string ST101_Seal_Ring_Below_SetValue { get; set; }

        [StringLength(50)]
        public string ST101_Seal_Ring_Above_TestValue { get; set; }

        [StringLength(50)]
        public string ST101_Seal_Ring_Above_SetValue { get; set; }

        [StringLength(50)]
        public string ST102_Date { get; set; }

        [StringLength(50)]
        public string ST102_Time { get; set; }

        [StringLength(50)]
        public string ST102_Package_Result { get; set; }

        [StringLength(50)]
        public string ST202_Date { get; set; }

        [StringLength(50)]
        public string ST202_Time { get; set; }

        [StringLength(50)]
        public string ST202_Package_Result { get; set; }

        [StringLength(50)]
        public string ST202_Rotor_5025805 { get; set; }

        [StringLength(50)]
        public string ST202_Camring_5026187 { get; set; }

        [StringLength(50)]
        public string ST202_Dowel_Pin_M0104893 { get; set; }

        [StringLength(50)]
        public string ST203_Date { get; set; }

        [StringLength(50)]
        public string ST203_Time { get; set; }

        [StringLength(50)]
        public string ST203_Package_Result { get; set; }

        [StringLength(50)]
        public string ST203_magnetic_flux_L { get; set; }

        [StringLength(50)]
        public string ST203_magnetic_flux_R { get; set; }

        [StringLength(50)]
        public string ST203_magnetic_flux_Upper { get; set; }

        [StringLength(50)]
        public string ST203_magnetic_flux_Lower { get; set; }

        [StringLength(50)]
        public string ST301_Date { get; set; }

        [StringLength(50)]
        public string ST301_Time { get; set; }

        [StringLength(50)]
        public string ST301_Package_Result { get; set; }

        [StringLength(50)]
        public string ST301_Vane_5004737 { get; set; }

        [StringLength(50)]
        public string ST301_Dowel_Pin_5024533 { get; set; }

        [StringLength(50)]
        public string ST301_Dowel_Pin_5020282 { get; set; }

        [StringLength(50)]
        public string ST302_Date { get; set; }

        [StringLength(50)]
        public string ST302_Time { get; set; }

        [StringLength(50)]
        public string ST302_Package_Result { get; set; }

        [StringLength(50)]
        public string ST302_Thin_PIN_Data { get; set; }

        [StringLength(50)]
        public string ST302_Coarse_PIN_Data { get; set; }

        [StringLength(50)]
        public string ST302_Thin_PIN_Tolerance { get; set; }

        [StringLength(50)]
        public string ST302_Coarse_PIN_Tolerance { get; set; }

        [StringLength(50)]
        public string ST401_Date { get; set; }

        [StringLength(50)]
        public string ST401_Time { get; set; }

        [StringLength(50)]
        public string ST401_Package_Result { get; set; }

        [StringLength(50)]
        public string ST401_Camera_Shield { get; set; }

        [StringLength(50)]
        public string ST402_Camera_Shield { get; set; }

        [StringLength(50)]
        public string ST403_Date { get; set; }

        [StringLength(50)]
        public string ST403_Time { get; set; }

        [StringLength(50)]
        public string ST403_Package_Result { get; set; }

        [StringLength(50)]
        public string ST403_Circlip_5026621 { get; set; }

        [StringLength(50)]
        public string ST403_Jump_Ring_Data { get; set; }

        [StringLength(50)]
        public string ST403_Jump_Ring_Tolerance { get; set; }

        [StringLength(50)]
        public string ST502_Date { get; set; }

        [StringLength(50)]
        public string ST502_Time { get; set; }

        [StringLength(50)]
        public string ST502_Package_Result { get; set; }

        [StringLength(50)]
        public string ST502_Camera_Shield { get; set; }

        [StringLength(50)]
        public string ST502_Form_Seal_5026860 { get; set; }

        [StringLength(50)]
        public string ST502_Support_Ring_5027083 { get; set; }

        [StringLength(50)]
        public string ST502_O_Ring_M0104976 { get; set; }

        [StringLength(50)]
        public string ST502_Pressure_Plate_M0105053 { get; set; }

        [StringLength(50)]
        public string ST502_Seal_Ring_TestValue { get; set; }

        [StringLength(50)]
        public string ST502_Seal_Ring_SetValue { get; set; }

        [StringLength(50)]
        public string ST503_Date { get; set; }

        [StringLength(50)]
        public string ST503_Time { get; set; }

        [StringLength(50)]
        public string ST503_Package_Result { get; set; }

        [StringLength(50)]
        public string ST601_Date { get; set; }

        [StringLength(50)]
        public string ST601_Time { get; set; }

        [StringLength(50)]
        public string ST601_Package_Result { get; set; }

        [StringLength(50)]
        public string ST601_Disk_Spring_5024300 { get; set; }

        [StringLength(50)]
        public string ST601_Sleeve_5020302 { get; set; }

        [StringLength(50)]
        public string ST601_Eclip_5018568 { get; set; }

        [StringLength(50)]
        public string ST602_Date { get; set; }

        [StringLength(50)]
        public string ST602_Time { get; set; }

        [StringLength(50)]
        public string ST602_Package_Result { get; set; }

        [StringLength(50)]
        public string ST70_Date { get; set; }

        [StringLength(50)]
        public string ST70_Time { get; set; }

        [StringLength(50)]
        public string ST70_Package_Result { get; set; }

        [StringLength(50)]
        public string ST70_Camera_Shield { get; set; }

        [StringLength(50)]
        public string ST70_Marking_Code_Class { get; set; }

        [StringLength(50)]
        public string ST70_Force { get; set; }

        [StringLength(50)]
        public string ST70_Force_Upper { get; set; }

        [StringLength(50)]
        public string ST70_Force_Lower { get; set; }

        [StringLength(50)]
        public string ST70_Displacement { get; set; }

        [StringLength(50)]
        public string ST70_Displacement_Upper { get; set; }

        [StringLength(50)]
        public string ST70_Displacement_Lower { get; set; }

        [StringLength(50)]
        public string ST70_Process_Pressure_Max { get; set; }

        [StringLength(50)]
        public string ST70_Process_Pressure_Upper { get; set; }

        [StringLength(50)]
        public string ST70_Process_Pressure_Lower { get; set; }

        [StringLength(50)]
        public string ST70_Shaft_Seal_5024366 { get; set; }

        [StringLength(50)]
        public string ST80_Date { get; set; }

        [StringLength(50)]
        public string ST80_Time { get; set; }

        [StringLength(50)]
        public string ST80_Marking_Code_Class { get; set; }
    }
}
