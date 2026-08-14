using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031E9")]
public class UIModelQuest : UIBaseModel
{
	[Token(Token = "0x401300C")]
	public const uint PropID_DailyBonus = 2u;

	[Token(Token = "0x401300D")]
	[FieldOffset(Offset = "0xC")]
	private DailyBonus m_DailyBonus;

	[Token(Token = "0x17001630")]
	public DailyBonus DailyBonus
	{
		[Token(Token = "0x60150E1")]
		[Address(RVA = "0x31393EC", Offset = "0x31393EC", VA = "0x31393EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60150E0")]
	[Address(RVA = "0x3139344", Offset = "0x3139344", VA = "0x3139344")]
	public UIModelQuest()
	{
	}

	[Token(Token = "0x60150E2")]
	[Address(RVA = "0x3139444", Offset = "0x3139444", VA = "0x3139444", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60150E3")]
	[Address(RVA = "0x313949C", Offset = "0x313949C", VA = "0x313949C")]
	public void RequestDailyBonus()
	{
	}

	[Token(Token = "0x60150E4")]
	[Address(RVA = "0x3139740", Offset = "0x3139740", VA = "0x3139740")]
	private void _003CRequestDailyBonus_003Em__0(HttpErrorCode errorCode, object res)
	{
	}
}
