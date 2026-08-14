using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x200238E")]
public class UISettingContentBase : UIBaseController
{
	[Token(Token = "0x400DD72")]
	[FieldOffset(Offset = "0x28")]
	protected bool IsIngameShow;

	[Token(Token = "0x600C7A4")]
	[Address(RVA = "0x222E828", Offset = "0x222E828", VA = "0x222E828")]
	public UISettingContentBase()
	{
	}

	[Token(Token = "0x600C7A5")]
	[Address(RVA = "0x2248EF4", Offset = "0x2248EF4", VA = "0x2248EF4", Slot = "31")]
	public virtual void SetInGameShow(bool isInGame)
	{
	}

	[Token(Token = "0x600C7A6")]
	[Address(RVA = "0x222EDE4", Offset = "0x222EDE4", VA = "0x222EDE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C7A7")]
	[Address(RVA = "0x2234040", Offset = "0x2234040", VA = "0x2234040", Slot = "32")]
	protected virtual void InitSettingInfo()
	{
	}

	[Token(Token = "0x600C7A8")]
	[Address(RVA = "0x222E994", Offset = "0x222E994", VA = "0x222E994", Slot = "33")]
	public virtual void RefreshContent(object[] param)
	{
	}
}
