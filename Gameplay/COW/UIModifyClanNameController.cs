using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029CC")]
public class UIModifyClanNameController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x401010D")]
	private const uint BTN_DEFUALT_COLOR = uint.MaxValue;

	[Token(Token = "0x401010E")]
	private const uint BTN_GREY_COLOR = 2593823487u;

	[Token(Token = "0x401010F")]
	[FieldOffset(Offset = "0x48")]
	private UIModifyClanNameView m_View;

	[Token(Token = "0x4010110")]
	[FieldOffset(Offset = "0x4C")]
	private ClanRenameData m_CostData;

	[Token(Token = "0x4010111")]
	[FieldOffset(Offset = "0x50")]
	private string m_ClanName;

	[Token(Token = "0x4010112")]
	private const int NAME_MIN_LENGTH = 3;

	[Token(Token = "0x4010113")]
	private const int NAME_MAX_LENGTH = 12;

	[Token(Token = "0x4010114")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010D07")]
	[Address(RVA = "0x194A97C", Offset = "0x194A97C", VA = "0x194A97C")]
	public UIModifyClanNameController()
	{
	}

	[Token(Token = "0x6010D08")]
	[Address(RVA = "0x194A984", Offset = "0x194A984", VA = "0x194A984")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010D09")]
	[Address(RVA = "0x194AA28", Offset = "0x194AA28", VA = "0x194AA28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D0A")]
	[Address(RVA = "0x194AD04", Offset = "0x194AD04", VA = "0x194AD04")]
	private void RefreshViewData()
	{
	}

	[Token(Token = "0x6010D0B")]
	[Address(RVA = "0x194B3DC", Offset = "0x194B3DC", VA = "0x194B3DC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010D0C")]
	[Address(RVA = "0x194B1E4", Offset = "0x194B1E4", VA = "0x194B1E4")]
	private void OnInputChange()
	{
	}

	[Token(Token = "0x6010D0D")]
	[Address(RVA = "0x194B50C", Offset = "0x194B50C", VA = "0x194B50C")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6010D0E")]
	[Address(RVA = "0x194BF98", Offset = "0x194BF98", VA = "0x194BF98", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010D0F")]
	[Address(RVA = "0x194BBDC", Offset = "0x194BBDC", VA = "0x194BBDC")]
	private void ShowRenameDiamondShortHint()
	{
	}

	[Token(Token = "0x6010D10")]
	[Address(RVA = "0x194C254", Offset = "0x194C254", VA = "0x194C254", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010D11")]
	[Address(RVA = "0x194C2E8", Offset = "0x194C2E8", VA = "0x194C2E8")]
	private static void _003CShowRenameDiamondShortHint_003Em__0()
	{
	}

	[Token(Token = "0x6010D12")]
	[Address(RVA = "0x194C380", Offset = "0x194C380", VA = "0x194C380")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010D13")]
	[Address(RVA = "0x194C388", Offset = "0x194C388", VA = "0x194C388")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
