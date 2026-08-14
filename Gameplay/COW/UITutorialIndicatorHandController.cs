using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023F4")]
public class UITutorialIndicatorHandController : UIBaseController
{
	[Token(Token = "0x400E036")]
	[FieldOffset(Offset = "0x28")]
	private UITutorialIndicatorHandView m_View;

	[Token(Token = "0x400E037")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<int, string> m_HandAnimDict;

	[Token(Token = "0x600CAF3")]
	[Address(RVA = "0x2B7D43C", Offset = "0x2B7D43C", VA = "0x2B7D43C")]
	public UITutorialIndicatorHandController()
	{
	}

	[Token(Token = "0x600CAF4")]
	[Address(RVA = "0x2B7D6D4", Offset = "0x2B7D6D4", VA = "0x2B7D6D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CAF5")]
	[Address(RVA = "0x2B7D790", Offset = "0x2B7D790", VA = "0x2B7D790")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CAF6")]
	[Address(RVA = "0x2B7B6B8", Offset = "0x2B7B6B8", VA = "0x2B7B6B8")]
	public void PlayAnim(TutorialUIType tutoType)
	{
	}

	[Token(Token = "0x600CAF7")]
	[Address(RVA = "0x2B7D834", Offset = "0x2B7D834", VA = "0x2B7D834")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
