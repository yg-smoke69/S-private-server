using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A4E")]
public class UIPetChangeNamePopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010403")]
	[FieldOffset(Offset = "0x48")]
	private UIChangeNamePopupWindowView m_View;

	[Token(Token = "0x4010404")]
	[FieldOffset(Offset = "0x4C")]
	private PetInfo m_PetData;

	[Token(Token = "0x4010405")]
	[FieldOffset(Offset = "0x50")]
	private PetRenameCostData m_CostData;

	[Token(Token = "0x4010406")]
	[FieldOffset(Offset = "0x54")]
	private bool m_HasRequestedRename;

	[Token(Token = "0x4010407")]
	[FieldOffset(Offset = "0x55")]
	private bool isFree;

	[Token(Token = "0x4010408")]
	[FieldOffset(Offset = "0x0")]
	private static Func<char, bool> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4010409")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60112D6")]
	[Address(RVA = "0x23F0AC4", Offset = "0x23F0AC4", VA = "0x23F0AC4")]
	public UIPetChangeNamePopupWindowController()
	{
	}

	[Token(Token = "0x60112D7")]
	[Address(RVA = "0x23F0ACC", Offset = "0x23F0ACC", VA = "0x23F0ACC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60112D8")]
	[Address(RVA = "0x23F0B70", Offset = "0x23F0B70", VA = "0x23F0B70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60112D9")]
	[Address(RVA = "0x23F0DD8", Offset = "0x23F0DD8", VA = "0x23F0DD8")]
	private void RefreshViewData()
	{
	}

	[Token(Token = "0x60112DA")]
	[Address(RVA = "0x23F1BE4", Offset = "0x23F1BE4", VA = "0x23F1BE4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60112DB")]
	[Address(RVA = "0x23F18E4", Offset = "0x23F18E4", VA = "0x23F18E4")]
	private void OnInputChange()
	{
	}

	[Token(Token = "0x60112DC")]
	[Address(RVA = "0x23F1D14", Offset = "0x23F1D14", VA = "0x23F1D14")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x60112DD")]
	[Address(RVA = "0x23F298C", Offset = "0x23F298C", VA = "0x23F298C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60112DE")]
	[Address(RVA = "0x23F2E00", Offset = "0x23F2E00", VA = "0x23F2E00", Slot = "42")]
	public override void EnterByReturn()
	{
	}

	[Token(Token = "0x60112DF")]
	[Address(RVA = "0x23F25D4", Offset = "0x23F25D4", VA = "0x23F25D4")]
	private void ShowRenameDiamondShortHint()
	{
	}

	[Token(Token = "0x60112E0")]
	[Address(RVA = "0x23F2EF8", Offset = "0x23F2EF8", VA = "0x23F2EF8", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60112E1")]
	[Address(RVA = "0x23F2F8C", Offset = "0x23F2F8C", VA = "0x23F2F8C")]
	private static void _003CShowRenameDiamondShortHint_003Em__0()
	{
	}

	[Token(Token = "0x60112E2")]
	[Address(RVA = "0x23F3024", Offset = "0x23F3024", VA = "0x23F3024")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60112E3")]
	[Address(RVA = "0x23F302C", Offset = "0x23F302C", VA = "0x23F302C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60112E4")]
	[Address(RVA = "0x23F3034", Offset = "0x23F3034", VA = "0x23F3034")]
	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}
}
