using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E52")]
public class UIModeEditGeneralComponentHelper
{
	[Token(Token = "0x4011B28")]
	[FieldOffset(Offset = "0x8")]
	public UIModelUGCModeEdit Model;

	[Token(Token = "0x4011B29")]
	[FieldOffset(Offset = "0xC")]
	public GeneralComponentData GeneralData;

	[Token(Token = "0x4011B2A")]
	[FieldOffset(Offset = "0x10")]
	public UIBaseController Context;

	[Token(Token = "0x4011B2B")]
	[FieldOffset(Offset = "0x14")]
	private UISprite BG;

	[Token(Token = "0x4011B2C")]
	[FieldOffset(Offset = "0x18")]
	private Action EnabledChanged;

	[Token(Token = "0x60135FC")]
	[Address(RVA = "0x13101DC", Offset = "0x13101DC", VA = "0x13101DC")]
	public UIModeEditGeneralComponentHelper(UIBaseController context, GeneralComponentData generalData)
	{
	}

	[Token(Token = "0x60135FD")]
	[Address(RVA = "0x1310398", Offset = "0x1310398", VA = "0x1310398")]
	public UIModeEditGeneralComponentHelper(UIBaseController context, GeneralComponentData generalData, UILabel title, UISprite bg, UIButton tip)
	{
	}

	[Token(Token = "0x60135FE")]
	[Address(RVA = "0x1310718", Offset = "0x1310718", VA = "0x1310718")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60135FF")]
	[Address(RVA = "0x131083C", Offset = "0x131083C", VA = "0x131083C")]
	public void HideBG()
	{
	}

	[Token(Token = "0x6013600")]
	[Address(RVA = "0x13108D8", Offset = "0x13108D8", VA = "0x13108D8")]
	public void ShowTip()
	{
	}

	[Token(Token = "0x6013601")]
	[Address(RVA = "0x1310B40", Offset = "0x1310B40", VA = "0x1310B40")]
	private void OnEnabledChanged()
	{
	}

	[Token(Token = "0x6013602")]
	[Address(RVA = "0x1310BF8", Offset = "0x1310BF8", VA = "0x1310BF8")]
	public void AddOnEnableChanged(Action callback)
	{
	}
}
