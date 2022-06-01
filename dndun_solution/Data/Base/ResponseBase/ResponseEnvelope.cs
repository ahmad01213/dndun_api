

namespace dndun_solution.Data.Base
{
  internal class ResponseEnvelope<T>
{
  public T Data { set; get; }
  public bool Status { set; get; }
  public int Code { set; get; }
  public string Message { set; get; }
}
}