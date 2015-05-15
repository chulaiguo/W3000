namespace W3000.IFacadeService
{
	public interface IFacadeServiceFactory
	{
		byte[] GetBizCreatorResult(string actionName, byte[] paras);
		byte[] GetBizEmailResult(string actionName, byte[] paras);
		byte[] GetBizExcelResult(string actionName, byte[] paras);
		byte[] GetBizLoginResult(string actionName, byte[] paras);
	}
}
