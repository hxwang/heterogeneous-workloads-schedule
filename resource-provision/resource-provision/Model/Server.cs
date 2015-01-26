using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace resource_provision.Model
{
    public class Server
    {
        public static decimal PowerRate { get; private set; }


        #region properties
        public List<VM> VMList { get; private set; }
        
        public decimal CPUCapacity { get; set; }

        /// <summary>
        /// get current CPU usage
        /// </summary>
        public decimal CPUUsage
        {
            get 
            {
                throw new NotImplementedException();
            }
        }

        public decimal PowerConsumption
        {
            get {
                return CPUUsage * PowerRate;
            }
        }

        public decimal AllocatedCPUCapacity
        {
            get {
                return VMList.Sum(vm => vm.Capacity);
            }
        
        }


        #endregion 

        public void AddVM(VM vm) {
            VMList.Add(vm);
        }

        public void ReleaseVM(VM vm) {
            if (VMList.Contains(vm))
                VMList.Remove(vm);
            else throw new InvalidOperationException("VM not exist! Cannot be release!");
        }

    }
}
