using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002303")]
public class UIRuleEndConditionSettingController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DA76")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleEndConditionSettingView m_View;

	[Token(Token = "0x400DA77")]
	[FieldOffset(Offset = "0x2C")]
	private int m_BGOriginalHeight;

	[Token(Token = "0x400DA78")]
	[FieldOffset(Offset = "0x30")]
	public EndConditionSetting Data;

	[Token(Token = "0x400DA79")]
	[FieldOffset(Offset = "0x34")]
	private UIRuleSmallNumericSettingController m_TimeUp;

	[Token(Token = "0x400DA7A")]
	[FieldOffset(Offset = "0x38")]
	private UIRuleSmallNumericSettingController m_Score;

	[Token(Token = "0x400DA7B")]
	[FieldOffset(Offset = "0x3C")]
	private UIRuleSmallToggleButtonGroupSettingController m_CSRounds;

	[Token(Token = "0x600C153")]
	[Address(RVA = "0x2BF2A2C", Offset = "0x2BF2A2C", VA = "0x2BF2A2C")]
	public UIRuleEndConditionSettingController()
	{
	}

	[Token(Token = "0x600C154")]
	[Address(RVA = "0x2BF2AB0", Offset = "0x2BF2AB0", VA = "0x2BF2AB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C155")]
	[Address(RVA = "0x2BF2B58", Offset = "0x2BF2B58", VA = "0x2BF2B58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C156")]
	[Address(RVA = "0x2BF2C4C", Offset = "0x2BF2C4C", VA = "0x2BF2C4C")]
	public void Init(EndConditionSetting data, [Optional] Action onDataChanged)
	{
	}

	[Token(Token = "0x600C157")]
	[Address(RVA = "0x2BF3744", Offset = "0x2BF3744", VA = "0x2BF3744", Slot = "31")]
	public void Reset()
	{
	}

	[Token(Token = "0x600C158")]
	[Address(RVA = "0x2BF397C", Offset = "0x2BF397C", VA = "0x2BF397C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
