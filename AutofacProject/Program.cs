using Autofac;
using AutofacProject.Task1;
using AutofacProject.Task2;

/*private static IContainer Container { get; set; }

var builder = new ContainerBuilder();
builder.RegisterType<ConsoleOutput>().As<IOutput>();
builder.RegisterType<TodayWriter>().As<IDateWriter>();
Container = builder.Build();

WriteDate();

public static void WriteDate()
{
    using(var scope = Container.BeginLefttimeScope())
    {
        var writer = scope.Resolve<IDateWriter>();
        writer.WriteDate();
    }
}*/

/*IQueryable<Memo> memos = new List<Memo>()
{
    new Memo {Title = "Release Autofac 1.0", DueAt = new DateTime(2007, 12, 14) },
    new Memo {Title = "Write AutofacProject", DueAt = DateTime.Now },
    new Memo {Title = "Release Autofac 3.0", DueAt = new DateTime(2022, 12, 30) }
}.AsQueryable();

//var checker = new MemoChecker(memos, new PrintingNotifier(Console.Out));
//checker.CheckNow();

//container.Resolve<MemoChecker>().CheckNow();

var builder = new ContainerBuilder();

builder.Register(c => new MemoChecker(c.Resolve<IQueryable<Memo>>(),
                                      c.Resolve<IMemoDueNotifier>()));
builder.Register(c => new PrintingNotifier(c.Resolve<TextWriter>())).As<IMemoDueNotifier>();

builder.RegisterInstance(memos);
builder.RegisterInstance(Console.Out).As<TextWriter>().ExternallyOwned();

using(var container = builder.Build())
{
    container.Resolve<MemoChecker>().CheckNow();
}

using (var appContainer = builder.Build())
{
    using (var requestLifeTime = appContainer.BeginLifetimeScope())
    {
        requestLifeTime.Resolve<MyRequestHandler>().Process();
    }
    using (var requestLifeTime2 = appContainer.BeginLifetimeScope())
    {
        requestLifeTime2.Resolve<MyRequestHandler>().Process();
    }
}*/

/*builder.Register(c => new MyClass()).SingleInstance();

var a = container.Resolve<MyClass>();
var b = container.Resolve<MyClass>();

builder.Register(c => new MyClass()).InstancePerLifeTimeScope();

var appContainer = builder.Build();
var sessionLifeTime = appContainer.BeginLifetimeScope();

builder.RegisterInstance(c => new MyClass(Settings.SomeSettings);

builder.Register<MyClass>((c, p) =>
{
    var account = p.Get<string>("account");
    if (account.StartsWith("9"))
        return new OtherClass();
    else
        return new OtherClass2();
});
*/

/*var builder = new ContainerBuilder();
builder.Register(c => new ChannelFactory<ITrackListing>(new BasicHttpBinding(),
    new EndPointAddress("http://localhost/Track"))).As<IChannelFactory<ItrackListing>>();

builder.Register(c => c.Resolve<IChannelFactory<ItrackListing>>().CreateChannel()).
    As<ItrackListing>().UseWcfSafeRelease();

using (var container = builder.Build())
{
    var trackService = container.Resolve<ItrackListing>();
    var tracks = trackService.GetTracks("text");

}*/