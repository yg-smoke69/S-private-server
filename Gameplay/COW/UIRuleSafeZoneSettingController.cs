using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200230B")]
public class UIRuleSafeZoneSettingController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DA9F")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleSafeZoneSettingView m_View;

	[Token(Token = "0x400DAA0")]
	[FieldOffset(Offset = "0x2C")]
	public SafeZoneRuleSetting Data;

	[Token(Token = "0x400DAA1")]
	[FieldOffset(Offset = "0x30")]
	public Action OnDataChanged;

	[Token(Token = "0x600C1B1")]
	[Address(RVA = "0x2BFD564", Offset = "0x2BFD564", VA = "0x2BFD564")]
	public UIRuleSafeZoneSettingController()
	{
	}

	[Token(Token = "0x600C1B2")]
	[Address(RVA = "0x2BFD5E8", Offset = "0x2BFD5E8", VA = "0x2BFD5E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C1B3")]
	[Address(RVA = "0x2BFD690", Offset = "0x2BFD690", VA = "0x2BFD690", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C1B4")]
	[Address(RVA = "0x2BFD7EC", Offset = "0x2BFD7EC", VA = "0x2BFD7EC")]
	public void Init(SafeZoneRuleSetting data)
	{
	}

	[Token(Token = "0x600C1B5")]
	[Address(RVA = "0x2BFDC08", Offset = "0x2BFDC08", VA = "0x2BFDC08", Slot = "31")]
	public void Reset()
	{
	}

	[Token(Token = "0x600C1B6")]
	[Address(RVA = "0x2BFE0B0", Offset = "0x2BFE0B0", VA = "0x2BFE0B0")]
	private void OnSliderChanged()
	{
	}

	[Token(Token = "0x600C1B7")]
	[Address(RVA = "0x2BFE3BC", Offset = "0x2BFE3BC", VA = "0x2BFE3BC")]
	public void RefreshSceneObject()
	{
	}

	[Token(Token = "0x600C1B8")]
	[Address(RVA = "0x2BFDF60", Offset = "0x2BFDF60", VA = "0x2BFDF60")]
	private void SetValue(float newValue)
	{
	}

	[Token(Token = "0x600C1B9")]
	[Address(RVA = "0x2BFE564", Offset = "0x2BFE564", VA = "0x2BFE564")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
