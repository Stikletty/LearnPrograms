using System;
using System.Management;
using System.Text;

//TODO 10: Compinfo.cs Documentation

namespace LearnPrograms
{
    class CompInfo
    {
        //Forrás: https://www.codeproject.com/Articles/362227/System-Information        

        public string DeviceInformation(string stringIn)
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            ManagementClass ManagementClass1 = new ManagementClass(stringIn);
            //Create a ManagementObjectCollection to loop through
            ManagementObjectCollection ManagemenobjCol = ManagementClass1.GetInstances();
            //Get the properties in the class
            PropertyDataCollection properties = ManagementClass1.Properties;
            string propertyValue = "";

            foreach (ManagementObject obj in ManagemenobjCol)
            {
                foreach (PropertyData property in properties)
                {
                    try
                    {

                        if (obj.Properties[property.Name].Value != null)
                        {
                            propertyValue = obj.Properties[property.Name].Value.ToString();
                        }
                        else
                        {
                            propertyValue = "Not Available";
                        }

                        StringBuilder1.AppendLine(property.Name + ":  " + propertyValue);

                        propertyValue = "";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                StringBuilder1.AppendLine();
            }

            StringBuilder1.Replace("\n", Environment.NewLine);
            return StringBuilder1.ToString();
        }

        public string SystemInformation()
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            try
            {
                StringBuilder1.AppendFormat("Operation System:  {0}\n", Environment.OSVersion);
                if (Environment.Is64BitOperatingSystem)
                    StringBuilder1.AppendFormat("\t\t  64 Bit Operating System\n");
                else
                    StringBuilder1.AppendFormat("\t\t  32 Bit Operating System\n");
                StringBuilder1.AppendFormat("SystemDirectory:  {0}\n", Environment.SystemDirectory);
                StringBuilder1.AppendFormat("ProcessorCount:  {0}\n", Environment.ProcessorCount);
                StringBuilder1.AppendFormat("UserDomainName:  {0}\n", Environment.UserDomainName);
                StringBuilder1.AppendFormat("UserName: {0}\n", Environment.UserName);
                //Drives
                StringBuilder1.AppendFormat("LogicalDrives:\n");
                foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
                {
                    try
                    {
                        StringBuilder1.AppendFormat("\t Drive: {0}\n\t\t VolumeLabel: " +
                          "{1}\n\t\t DriveType: {2}\n\t\t DriveFormat: {3}\n\t\t " +
                          "TotalSize: {4}\n\t\t AvailableFreeSpace: {5}\n",
                          DriveInfo1.Name, DriveInfo1.VolumeLabel, DriveInfo1.DriveType,
                          DriveInfo1.DriveFormat, DriveInfo1.TotalSize, DriveInfo1.AvailableFreeSpace);
                    }
                    catch
                    {
                    }
                }
                StringBuilder1.AppendFormat("SystemPageSize:  {0}\n", Environment.SystemPageSize);
                StringBuilder1.AppendFormat("Version:  {0}", Environment.Version);
            }
            catch
            {
            }

            //Textbox linebreak
            StringBuilder1.Replace("\n", Environment.NewLine);
            return StringBuilder1.ToString();
        }

        public string RemoteComputerInfoGeneral(string strUsername, string strPassword, string strIP)
        {
            //ListBox ListBoxResult = ListBoxIn;
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);

            ConnectionOptions options = new ConnectionOptions();
            options.Username = strUsername;
            options.Password = strPassword;
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.EnablePrivileges = true;
            try
            {
                ManagementScope ManagementScope1 = new ManagementScope(string.Format("\\\\{0}\\root\\cimv2", strIP), options);
                ManagementScope1.Connect();
                ObjectGetOptions objectGetOptions = new ObjectGetOptions();
                ManagementPath managementPath1 = new ManagementPath("Win32_OperatingSystem");
                ManagementClass ManagementClass1 = new ManagementClass(ManagementScope1, managementPath1, objectGetOptions);

                foreach (ManagementObject ManagementObject1 in ManagementClass1.GetInstances())
                {
                    // Display the remote computer information
                    StringBuilder1.AppendFormat("Computer Name : {0}" + Environment.NewLine, ManagementObject1["csname"]);
                    StringBuilder1.AppendFormat("Windows Directory : {0}" + Environment.NewLine, ManagementObject1["WindowsDirectory"]);
                    StringBuilder1.AppendFormat("Operating System: {0}" + Environment.NewLine, ManagementObject1["Caption"]);
                    StringBuilder1.AppendFormat("Version: {0}" + Environment.NewLine, ManagementObject1["Version"]);
                    StringBuilder1.AppendFormat("Manufacturer : {0}" + Environment.NewLine, ManagementObject1["Manufacturer"]);
                    StringBuilder1.AppendFormat("Latest bootup time : {0}" + Environment.NewLine, ManagementObject1["LastBootUpTime"]);
                }
            }
            catch (Exception ex)
            {
                StringBuilder1.AppendFormat("Can't Connect to Server: {0}\n{1}" + Environment.NewLine, strIP, ex.Message);
            }

            return StringBuilder1.ToString();
        }

        public string RemoteComputerInfo(string strUsername, string strPassword, string strIP, string stringWin32class)
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);

            ConnectionOptions options = new ConnectionOptions();
            options.Username = strUsername;
            options.Password = strPassword;
            options.Impersonation = ImpersonationLevel.Impersonate;
            options.EnablePrivileges = true;
            try
            {
                ManagementScope ManagementScope1 = new ManagementScope(string.Format("\\\\{0}\\root\\cimv2", strIP), options);
                ManagementScope1.Connect();

                ObjectGetOptions objectGetOptions = new ObjectGetOptions();
                ManagementPath managementPath1 = new ManagementPath(stringWin32class);
                ManagementClass ManagementClass1 = new ManagementClass(ManagementScope1, managementPath1, objectGetOptions);

                PropertyDataCollection PropertyDataCollection1 = ManagementClass1.Properties;

                foreach (ManagementObject ManagementObject1 in ManagementClass1.GetInstances())
                {
                    foreach (PropertyData property in PropertyDataCollection1)
                    {
                        try
                        {
                            // Display the remote computer system information in input listbox
                            StringBuilder1.AppendLine(string.Format(property.Name + ":  " +
                              ManagementObject1.Properties[property.Name].Value.ToString()));
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder1.AppendLine(string.Format("Can't Connect to Server: {0}\n{1}", strIP, ex.Message));
            }

            return StringBuilder1.ToString();
        }

    }
}
