using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001EF0")]
public class UIDigitaluniversebSignInController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C2DD")]
	[FieldOffset(Offset = "0x48")]
	private UIDigitaluniversebSignInView m_View;

	[Token(Token = "0x400C2DE")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x600972A")]
	[Address(RVA = "0x275AF1C", Offset = "0x275AF1C", VA = "0x275AF1C")]
	public UIDigitaluniversebSignInController()
	{
	}

	[Token(Token = "0x600972B")]
	[Address(RVA = "0x275AF24", Offset = "0x275AF24", VA = "0x275AF24")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600972C")]
	[Address(RVA = "0x275AFCC", Offset = "0x275AFCC", VA = "0x275AFCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600972D")]
	[Address(RVA = "0x275B1AC", Offset = "0x275B1AC", VA = "0x275B1AC")]
	private void OnClickSignInBtn()
	{
	}

	[Token(Token = "0x600972E")]
	[Address(RVA = "0x275B284", Offset = "0x275B284", VA = "0x275B284", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600972F")]
	[Address(RVA = "0x275B318", Offset = "0x275B318", VA = "0x275B318", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009730")]
	[Address(RVA = "0x275B3E8", Offset = "0x275B3E8", VA = "0x275B3E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
