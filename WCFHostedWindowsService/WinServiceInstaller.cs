using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceProcess;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Configuration.Install;

namespace WCFHostedWindowsService
{
    [RunInstaller(true)]
    public class WinServiceInstaller : Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public WinServiceInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.NetworkService;
            service = new ServiceInstaller();
            service.ServiceName = "WCFHostedWindowsService";
            service.DisplayName = "WCFHostedWindowsService";
            service.Description = "WCF Service Hosted";
            service.StartType = ServiceStartMode.Automatic;
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
