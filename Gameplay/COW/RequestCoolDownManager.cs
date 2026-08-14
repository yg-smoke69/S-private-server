using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D7F")]
internal class RequestCoolDownManager : SingletonModule<RequestCoolDownManager>
{
	[Token(Token = "0x401175A")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, Timer> m_CoolDownTimerDictionary;

	[Token(Token = "0x60130B5")]
	[Address(RVA = "0x2406BE8", Offset = "0x2406BE8", VA = "0x2406BE8")]
	public RequestCoolDownManager()
	{
	}

	[Token(Token = "0x60130B6")]
	[Address(RVA = "0x2406CAC", Offset = "0x2406CAC", VA = "0x2406CAC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60130B7")]
	[Address(RVA = "0x2406D00", Offset = "0x2406D00", VA = "0x2406D00", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60130B8")]
	[Address(RVA = "0x2406D54", Offset = "0x2406D54", VA = "0x2406D54")]
	public bool CheckIsNeedRequest(string requestType, float CoolDownSecounds = 1f)
	{
		return default(bool);
	}

	[Token(Token = "0x60130B9")]
	[Address(RVA = "0x2407268", Offset = "0x2407268", VA = "0x2407268")]
	public void UpdateExpiredTime(string requestType, float CoolDownSecounds = 1f)
	{
	}

	[Token(Token = "0x60130BA")]
	[Address(RVA = "0x2407418", Offset = "0x2407418", VA = "0x2407418")]
	public void ResetExpiredTime(string requestType)
	{
	}
}
