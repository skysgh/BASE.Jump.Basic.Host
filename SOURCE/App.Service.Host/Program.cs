
using App.Base.IoC.Lamar;

namespace App.Host.Web
{
    /// <summary>
    /// Main entry class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Entry Function for the website.
        /// <para>
        /// Invoked by the underlying webservice 
        /// in its own memory space and threads.
        /// </para>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // One can use any mainstream IoC.
            // Lamar is the enheritor of StructureMap, and fast
            var ioCInitialiser = new LamarIoCInitialiser();
            // But Autofac, older, has child Containers
            // which is a required feature for handling late loaded Plugins:
            //var ioCInitialiser = new AutofacIoCInitialiser();

            // That's it...
            new AppStartup(
                ioCInitialiser)
                .Go(args);
        }
    }
}