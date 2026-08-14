using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032BC")]
internal class UIModelVoice : UIBaseModel
{
	[Token(Token = "0x4013515")]
	[FieldOffset(Offset = "0x10")]
	private ulong m_MutedTimeStamp;

	[Token(Token = "0x4013516")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<ulong, ulong> m_ReportedPlayerTimeDict;

	[Token(Token = "0x170016B2")]
	public Dictionary<ulong, ulong> ReportedPlayerTimeDict
	{
		[Token(Token = "0x601567E")]
		[Address(RVA = "0x19418CC", Offset = "0x19418CC", VA = "0x19418CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601567D")]
	[Address(RVA = "0x1941814", Offset = "0x1941814", VA = "0x1941814")]
	public UIModelVoice()
	{
	}

	[Token(Token = "0x601567F")]
	[Address(RVA = "0x1941924", Offset = "0x1941924", VA = "0x1941924", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015680")]
	[Address(RVA = "0x194197C", Offset = "0x194197C", VA = "0x194197C")]
	public bool IsMuted()
	{
		return default(bool);
	}

	[Token(Token = "0x6015681")]
	[Address(RVA = "0x1941A60", Offset = "0x1941A60", VA = "0x1941A60", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6015682")]
	[Address(RVA = "0x1941BEC", Offset = "0x1941BEC", VA = "0x1941BEC")]
	public void SetMutedTime(long timeToLive)
	{
	}

	[Token(Token = "0x6015683")]
	[Address(RVA = "0x1941D78", Offset = "0x1941D78", VA = "0x1941D78")]
	public string CalMutedTime()
	{
		return null;
	}

	[Token(Token = "0x6015684")]
	[Address(RVA = "0x1941E50", Offset = "0x1941E50", VA = "0x1941E50")]
	public bool TryReportVoice(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x6015685")]
	[Address(RVA = "0x1942D40", Offset = "0x1942D40", VA = "0x1942D40", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015686")]
	[Address(RVA = "0x1942E24", Offset = "0x1942E24", VA = "0x1942E24")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6015687")]
	[Address(RVA = "0x1942E2C", Offset = "0x1942E2C", VA = "0x1942E2C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
