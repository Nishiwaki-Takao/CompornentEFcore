using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramwork

namespace ClassAsProperty
{
    public static class ContextUtility
    {
        private void ConfigureeCAPProperty<T,T2,T3> where T
        static void ConfigureCAPONETOONE<T,T2,T3>()where T : IClassAsProperty<T3> where T2 
        {
            modelBuilder.Entity<T>(e =>
            {
                e.HasKey(e => e.InstalledTubID);
                e.Property(e => e.InstalledTubID).IsRequired();
                e.Property(e => e.Uninstalldate).IsRequired();
                e.HasOne(e => e.Unistalledtub)
                 .WithOne(d => d.UninstallDate)
                 .HasForeignKey<TubUninstallDay>(e => e.InstalledTubID);
                ;
            });
        }

        static void ConfigureCompoundClass<T,T2>()
    }
}
