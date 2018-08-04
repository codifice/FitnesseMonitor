namespace FitnesseMonitorAcceptance
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    public class Division
    {
        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed. Suppression is OK here.")]
#pragma warning disable S1104 // Fields should not have public accessibility
        public decimal Denominator = 0.0m;

        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed. Suppression is OK here.")]
        public decimal Numerator = 0.0m;

        [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed. Suppression is OK here.")]
        public int Wait = 0;
#pragma warning restore S1104 // Fields should not have public accessibility

        public decimal Quotient()
        {
            if (this.Denominator == 0)
            {
                throw new NotSupportedException($"{nameof(this.Denominator)} cannot be zero");
            }
            if (this.Wait > 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(this.Wait));
            }

            return this.Numerator / this.Denominator;
        }
    }
}