namespace TfmrLib
{
    public interface IMaterial
    {
        abstract double eps_r { get; }
        abstract double mu_r { get; }
        abstract double rho { get; }
    }

    public class Air : IMaterial
    {
        // A single, shared, read-only instance
        public static Air Instance { get; } = new Air();

        public double eps_r => 1.0;
        public double mu_r => 1.0;
        public double rho => double.PositiveInfinity;
    }

    public class Copper : IMaterial
    {
        // A single, shared, read-only instance
        public static Copper Instance { get; } = new Copper();

        public double eps_r => 1.0;
        public double mu_r => 1.0;
        public double rho => 1.68e-8; // Ohm-m
    }

    public class Paper : IMaterial
    {
        // A single, shared, read-only instance
        public static Paper Instance { get; } = new Paper();

        public double eps_r => 1.0;
        public double mu_r => 1.0;
        public double rho => double.PositiveInfinity;
    }

    public class Oil : IMaterial
    {
        // A single, shared, read-only instance
        public static Oil Instance { get; } = new Oil();

        public double eps_r => 1.0;
        public double mu_r => 1.0;
        public double rho => double.PositiveInfinity;
    }

    public class Aluminum : IMaterial
    {
        // A single, shared, read-only instance
        public static Aluminum Instance { get; } = new Aluminum();

        public double eps_r => 1.0;
        public double mu_r => 1.0;
        public double rho => 3.99e-8; // Ohm-m (Aluminum 6061)
    }


}