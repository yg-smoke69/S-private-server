using Il2CppDummyDll;

namespace UMA.Simple;

[Token(Token = "0x2003C75")]
public class AsyncLoadReqPool : ListPoolWithIndexedObjects<AsyncLoadReq>
{
	[Token(Token = "0x6018228")]
	[Address(RVA = "0x2D557D0", Offset = "0x2D557D0", VA = "0x2D557D0")]
	public AsyncLoadReqPool()
	{
	}

	[Token(Token = "0x6018229")]
	[Address(RVA = "0x2D55834", Offset = "0x2D55834", VA = "0x2D55834", Slot = "4")]
	protected override AsyncLoadReq Create()
	{
		return null;
	}

	[Token(Token = "0x601822A")]
	[Address(RVA = "0x2D5593C", Offset = "0x2D5593C", VA = "0x2D5593C", Slot = "5")]
	protected override void OnAllocate(AsyncLoadReq r)
	{
	}

	[Token(Token = "0x601822B")]
	[Address(RVA = "0x2D55A34", Offset = "0x2D55A34", VA = "0x2D55A34", Slot = "6")]
	protected override void OnRelease(AsyncLoadReq r)
	{
	}
}
