using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using test1.Data;

namespace test1
{
     public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            
            container.Register(new MessageRepository(EnvironmentVariable.GetValueOrDefault("MessageConnectionString", "mongodb://localhost")));
            base.ApplicationStartup(container, pipelines);
        }

        public override void Configure(Nancy.Configuration.INancyEnvironment environment)
        {
            environment.Tracing(enabled: false, displayErrorTraces: true);
        }
    }
}