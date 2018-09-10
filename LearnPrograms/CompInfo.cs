using System;
using System.Management;
using System.Text;
using System.Windows.Forms;

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
            foreach (ManagementObject obj in ManagemenobjCol)
            {
                foreach (PropertyData property in properties)
                {
                    try
                    {
                        StringBuilder1.AppendLine(property.Name + ":  " +
                          obj.Properties[property.Name].Value.ToString());
                    }
                    catch
                    {
                        //Add codes to manage more informations
                    }
                }
                StringBuilder1.AppendLine();
            }
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
                    catch (Exception exDriveInfo)
                    {
                        Console.WriteLine("StringBuild error: ", exDriveInfo.ToString());
                    }
                }
                StringBuilder1.AppendFormat("SystemPageSize:  {0}\n", Environment.SystemPageSize);
                StringBuilder1.AppendFormat("Version:  {0}", Environment.Version);
            }
            catch (Exception exEnvironment)
            {
                Console.WriteLine("StringBuild error: ", exEnvironment.ToString());
            }
            return StringBuilder1.ToString();
        }

        private void RemoteComputerInfo(string strUsername, string strPassword, string strIP, ListBox ListBoxIn, string stringWin32class)
        {
            ListBox ListBoxResult = ListBoxIn;
            ListBoxResult.Items.Clear();

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
                            ListBoxResult.Items.Add(string.Format(property.Name + ":  " +
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
                ListBoxResult.Items.Add(string.Format("Can't Connect to Server: {0}\n{1}", strIP, ex.Message));
            }
        }

        private void RemoteComputerInfoCustomized(string strUsername, string strPassword, string strIP, ListBox ListBoxIn)
        {
            ListBox ListBoxResult = ListBoxIn;
            ListBoxResult.Items.Clear();

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
                    ListBoxResult.Items.Add(string.Format("Computer Name : {0}", ManagementObject1["csname"]));
                    ListBoxResult.Items.Add(string.Format("Windows Directory : {0}", ManagementObject1["WindowsDirectory"]));
                    ListBoxResult.Items.Add(string.Format("Operating System: {0}", ManagementObject1["Caption"]));
                    ListBoxResult.Items.Add(string.Format("Version: {0}", ManagementObject1["Version"]));
                    ListBoxResult.Items.Add(string.Format("Manufacturer : {0}", ManagementObject1["Manufacturer"]));
                    ListBoxResult.Items.Add(string.Format("Latest bootup time : {0}", ManagementObject1["LastBootUpTime"]));
                }
            }
            catch (Exception ex)
            {
                ListBoxResult.Items.Add(string.Format("Can't Connect to Server: {0}\n{1}", strIP, ex.Message));
            }
        }

    }
}
