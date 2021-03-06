namespace DotNet.Testcontainers.Containers.OutputConsumers
{
  using System.IO;

  public interface IOutputConsumer
  {
    Stream Stdout { get; }

    Stream Stderr { get; }
  }
}
