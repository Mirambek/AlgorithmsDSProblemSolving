namespace Apps.Common
{
  public interface IApp
  {
    T Run<T>(T data) where T:class;
  }
}