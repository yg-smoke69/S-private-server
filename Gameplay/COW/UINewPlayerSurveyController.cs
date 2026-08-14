using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029EA")]
public class UINewPlayerSurveyController : UIBaseController, _Attribute
{
	[Token(Token = "0x40101CB")]
	[FieldOffset(Offset = "0x28")]
	protected UINewPlayerSurveyView m_View;

	[Token(Token = "0x40101CC")]
	[FieldOffset(Offset = "0x2C")]
	private string link;

	[Token(Token = "0x6010E11")]
	[Address(RVA = "0x27ACF70", Offset = "0x27ACF70", VA = "0x27ACF70")]
	public UINewPlayerSurveyController()
	{
	}

	[Token(Token = "0x6010E12")]
	[Address(RVA = "0x27AD03C", Offset = "0x27AD03C", VA = "0x27AD03C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E13")]
	[Address(RVA = "0x27AD0E4", Offset = "0x27AD0E4", VA = "0x27AD0E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010E14")]
	[Address(RVA = "0x27AD73C", Offset = "0x27AD73C", VA = "0x27AD73C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010E15")]
	[Address(RVA = "0x27AD86C", Offset = "0x27AD86C", VA = "0x27AD86C")]
	protected void Update()
	{
	}

	[Token(Token = "0x6010E16")]
	[Address(RVA = "0x27AD9C4", Offset = "0x27AD9C4", VA = "0x27AD9C4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010E17")]
	[Address(RVA = "0x27ADA90", Offset = "0x27ADA90", VA = "0x27ADA90", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010E18")]
	[Address(RVA = "0x27AD2D8", Offset = "0x27AD2D8", VA = "0x27AD2D8")]
	private void RefreshLink()
	{
	}

	[Token(Token = "0x6010E19")]
	[Address(RVA = "0x27AE2A8", Offset = "0x27AE2A8", VA = "0x27AE2A8")]
	private void onSurveyClick()
	{
	}

	[Token(Token = "0x6010E1A")]
	[Address(RVA = "0x27AE5A4", Offset = "0x27AE5A4", VA = "0x27AE5A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010E1B")]
	[Address(RVA = "0x27AE5AC", Offset = "0x27AE5AC", VA = "0x27AE5AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
